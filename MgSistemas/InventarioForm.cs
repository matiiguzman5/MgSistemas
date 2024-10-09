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


        private void CargarProductos()
        {
            using (var context = new PanolContext())
            {
                // Obtiene todos los productos de la base de datos y los convierte a una lista.
                var productos = context.Productos.ToList();

                // Asigna la lista de productos como fuente de datos del DataGridView.
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
            var AgregarProductoForm = new AgregarProductoForm();
            AgregarProductoForm.Show();

            this.Close();
        }

       
    }

}
