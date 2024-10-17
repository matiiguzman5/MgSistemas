using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MgSistemas.PanolContext;




namespace MgSistemas
{
    public partial class InventarioForm : Form
    {
        private Usuario _usuarioActual;

        public InventarioForm(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void InventarioForm_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }


        public void CargarProductos()
        {
            using (var context = new PanolContext())
            {

                var productos = context.Productos.ToList();
                dataGridViewProductos.DataSource = productos;
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.CurrentRow != null)
            {
                int idProducto = (int)dataGridViewProductos.CurrentRow.Cells["IdProducto"].Value;
                var edicionForm = new EdicionForm(idProducto, _usuarioActual, this);
                edicionForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecciona un producto para editar.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchTerm = txtBuscar.Text.ToLower();

            using (var context = new PanolContext())
            {
                int codigoProducto;
                bool isNumeric = int.TryParse(searchTerm, out codigoProducto);

                var productos = context.Productos
                    .Where(p => (isNumeric && p.CodigoProducto == codigoProducto) ||
                                p.Nombre.ToLower().Contains(searchTerm) ||
                                p.Categoria.ToLower().Contains(searchTerm) ||
                                p.Descripcion.ToLower().Contains(searchTerm))
                    .ToList();

                dataGridViewProductos.DataSource = productos;
            }
        }

        private void btnVolverMainInv_Click(object sender, EventArgs e)
        {

            var mainForm = new MainForm(_usuarioActual);
            mainForm.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var agregarProductoForm = new AgregarProductoForm(this, _usuarioActual);
            agregarProductoForm.ShowDialog();

            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.CurrentRow != null)
            {
                int idProducto = (int)dataGridViewProductos.CurrentRow.Cells["IdProducto"].Value;

                var result = MessageBox.Show("¿Estas seguro de que deseas eliminar este producto?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result == DialogResult.Yes)
                {
                    using (var context = new PanolContext())
                    {
                        var producto = context.Productos.FirstOrDefault(p => p.IdProducto == idProducto);

                        if (producto != null)
                        {
                            var movimientoEliminacion = new Movimiento
                            {
                                IdProducto = producto.IdProducto,
                                Cantidad = producto.StockActual, // Registrar la cantidad que se está eliminando
                                FechaMovimiento = DateTime.Now,
                                TipoMovimiento = "Eliminación",
                                Usuario = _usuarioActual.NombreUsuario, // Usuario que realiza la eliminación
                                Detalles = "Producto eliminado del inventario"
                            };

                            context.Movimientos.Add(movimientoEliminacion);

                            context.Productos.Remove(producto);
                            context.SaveChanges();

                            MessageBox.Show("El producto fue eliminado correctamente.");

                            CargarProductos();
                        }
                        else
                        {
                            MessageBox.Show("Por favor, selecciona un producto para eliminar.");
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMoviento_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.CurrentRow != null)
            {
                int idProducto = (int)dataGridViewProductos.CurrentRow.Cells["IdProducto"].Value;
                var movimientoForm = new MovimientoForm(idProducto, _usuarioActual, this);
                movimientoForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para gestionar el movimiento");
            }


        }

        private void btnVerMovimientos_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewProductos.CurrentRow != null)
            {
                                
                var cargarMovimientos= new CargarMovimientos( _usuarioActual);
                cargarMovimientos.Show();

                
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para ver sus movimientos.");
            }
        }
    }

}
