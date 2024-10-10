using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MgSistemas
{
    public partial class InventarioForm : Form
    {
        public InventarioForm()
        {
            InitializeComponent();
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

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchTerm = txtBuscar.Text.ToLower();

            using (var context = new PanolContext())
            {
                var productos = context.Productos
                    .Where(p => p.Nombre.ToLower().Contains(searchTerm) ||
                                p.Categoria.ToLower().Contains(searchTerm) ||
                                p.Descripcion.ToLower().Contains(searchTerm))
                    .ToList();

                dataGridViewProductos.DataSource = productos;
            }
        }

        private void btnVolverMainInv_Click(object sender, EventArgs e)
        {
            var MainForm = new MainForm();
            MainForm.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var agregarProductoForm = new AgregarProductoForm(this); 
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
    }

}
