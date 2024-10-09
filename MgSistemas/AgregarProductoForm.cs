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
    public partial class AgregarProductoForm : Form
    {
        public AgregarProductoForm()
        {
            InitializeComponent();
            


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void btnVolverProd_Click(object sender, EventArgs e)
        {
            var InventarioForm = new InventarioForm();
            InventarioForm.Show();
            this.Close();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregaProd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.");
                return;
            }

            if (numericCantProd.Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.");
                return;
            }

            int codigoProducto = (int)numericCodeProd.Value;

            using (var context = new PanolContext())
            {
                var productoExistente = context.Productos
                    .FirstOrDefault(p => p.CodigoProducto == codigoProducto);

                if(productoExistente != null)
                {
                    MessageBox.Show("Ya este un producto con este codigo. Porfavor, Ingresar un codigo de Producto Distinto");
                    return ;
                }


                var Productos = new Producto
                {
                    CodigoProducto = codigoProducto,
                    Nombre = txtNombreProducto.Text,
                    Descripcion = txtDescripcion.Text,
                    Categoria = CategoriaBox.SelectedItem?.ToString()?? "Sin categoria",
                    StockActual = (int)numericCantProd.Value,
                    FechaIngreso = dtpFechaIngreso.Value
                };

                context.Productos.Add(Productos);
                context.SaveChanges();

                MessageBox.Show("Producto Agregado Correctamente");
                LimpiarCampos();
            }
        }

        private void LimpiarCampos() {
            txtNombreProducto.Clear();
            txtDescripcion.Clear();
            CategoriaBox.SelectedIndex = -1;
            numericCantProd.Value = 1;
            dtpFechaIngreso.Value = DateTime.Now;
        }

        private void CategoriaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoriaBox.Items.Add("Repuestos");
            CategoriaBox.Items.Add("Accesorios");
            CategoriaBox.Items.Add("Sistemas");
            CategoriaBox.Items.Add("Administrativo");
        }
    }
}
