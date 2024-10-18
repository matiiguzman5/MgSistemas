using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using static MgSistemas.PanolContext;

namespace MgSistemas
{
    public partial class RequerimientoForm : Form
    {
        public RequerimientoForm()
        {
            InitializeComponent();
        }

        private void RequerimientoForm_Load(object sender, EventArgs e)
        {
            using (var context = new PanolContext())
            {
                // Cargar productos
                var productos = context.Productos.ToList();
                comboBoxSelecProd.DataSource = productos;
                comboBoxSelecProd.DisplayMember = "Nombre";
                comboBoxSelecProd.ValueMember = "IdProducto";

                // Cargar usuarios en el ComboBox de responsables
                var usuarios = context.Usuarios.Where(u => u.Activo == true).ToList();
                comboBoxUsers.DataSource = usuarios;
                comboBoxUsers.DisplayMember = "NombreUsuario"; // Muestra el nombre de usuario
                comboBoxUsers.ValueMember = "IdUsuario"; // El valor será el IdUsuario
            }
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var producto = (Producto)comboBoxSelecProd.SelectedItem;
            int cantidad = (int)numericCantidad.Value;

            if (producto == null || cantidad <= 0)
            {
                MessageBox.Show("Por favor, selecciona un producto y una cantidad válida.");
                return;
            }

            // Agregar el CódigoProducto como una columna oculta y el nombre del producto y cantidad como visibles
            dataGridViewProductos.Rows.Add(producto.CodigoProducto, producto.Nombre, cantidad);

            comboBoxSelecProd.SelectedIndex = -1;
            numericCantidad.Value = 0;
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.CurrentRow != null)
            {
                dataGridViewProductos.Rows.Remove(dataGridViewProductos.CurrentRow);
            }
            else
            {
                MessageBox.Show("Por favor selecciona un producto para eliminar");
            }
        }

        private void btnNuevoRq_Click(object sender, EventArgs e)
        {
            groupBoxRequerimiento.Enabled = true;
            txtNroRequerimiento.Text = "";
            txtObservaciones.Clear();
            dtpFechaSolicitud.Value = DateTime.Now;

            dataGridViewProductos.Rows.Clear();

            btnAgregar.Enabled = true;
            btnEliminar.Enabled = true;

            MessageBox.Show("Listo para crear un nuevo requerimiento.");
        }

        private void btnModificarRq_Click(object sender, EventArgs e)
        {
            int nroRequerimiento;

            if (!int.TryParse(txtNroRequerimiento.Text, out nroRequerimiento))
            {
                MessageBox.Show("Por favor, ingresa un número de requerimiento válido");
                return;
            }

            using (var context = new PanolContext())
            {
                var requerimiento = context.Requerimientos
                    .Include(r => r.Productos)
                    .FirstOrDefault(r => r.NroRequerimiento == nroRequerimiento);

                if (requerimiento != null)
                {
                    comboBoxUsers.Text = requerimiento.Responsable;
                    dtpFechaSolicitud.Value = requerimiento.FechaEntrega;
                    txtObservaciones.Text = requerimiento.Observaciones;

                    dataGridViewProductos.Rows.Clear();
                    foreach (var producto in requerimiento.Productos)
                    {
                        var productoInfo = context.Productos.FirstOrDefault(p => p.IdProducto == producto.IdProducto);
                        dataGridViewProductos.Rows.Add(productoInfo.Nombre, producto.Cantidad);
                    }

                    groupBoxRequerimiento.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Requerimiento no encontrado");
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new PanolContext())
                {
                    string prioridad = rbtnNormal.Checked ? "Normal" : "Alta";

                    var nuevoRequerimiento = new Requerimiento
                    {
                        Responsable = comboBoxUsers.Text,
                        FechaEntrega = dtpFechaSolicitud.Value,
                        Observaciones = txtObservaciones.Text,
                        Prioridad = prioridad,  // Asignar la prioridad
                        Productos = new List<ProductoRequerido>()
                    };

                    foreach (DataGridViewRow row in dataGridViewProductos.Rows)
                    {
                        if (row.Cells["CodigoProducto"].Value != null && row.Cells["Cantidad"].Value != null)
                        {
                            // Encontrar el producto por su CódigoProducto en la base de datos
                            var codigoProducto = (int)row.Cells["CodigoProducto"].Value;
                            var producto = context.Productos.FirstOrDefault(p => p.CodigoProducto == codigoProducto);

                            if (producto != null)
                            {
                                var productoRequerido = new ProductoRequerido
                                {
                                    IdProducto = producto.IdProducto, // Asigna el IdProducto internamente
                                    Cantidad = (int)row.Cells["Cantidad"].Value
                                };

                                nuevoRequerimiento.Productos.Add(productoRequerido);
                            }
                        }
                    }

                    context.Requerimientos.Add(nuevoRequerimiento);
                    context.SaveChanges();

                    MessageBox.Show("Requerimiento Generado Correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}\nDetalles: {ex.InnerException?.Message}");
            }
        }


        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxSelecProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            // No necesitas recargar productos cada vez que cambia la selección, por lo que este método puede estar vacío
        }

        private void groupBoxRequerimiento_Enter(object sender, EventArgs e)
        {

        }
    }
}
