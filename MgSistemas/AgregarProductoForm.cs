using Microsoft.EntityFrameworkCore;
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

        private InventarioForm _inventarioForm;
        private Producto _producto;
        private Usuario _usuarioActual;

        public AgregarProductoForm(InventarioForm inventarioForm, Usuario usuarioActual)
        {
            _inventarioForm = inventarioForm;
            InitializeComponent();
            _usuarioActual = usuarioActual;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void btnVolverProd_Click(object sender, EventArgs e)
        {
            var InventarioForm = new InventarioForm(_usuarioActual);
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
            int cantidadIngresada = (int)numericCantProd.Value;
            string nombreProducto = txtNombreProducto.Text.ToLower();

            using (var context = new PanolContext())
            {
                
                var productoExistente = context.Productos
                    .FirstOrDefault(p => p.CodigoProducto == codigoProducto);

                if (productoExistente != null)
                {
                    
                    if (productoExistente.Nombre.ToLower() == nombreProducto)
                    {
                        
                        var result = MessageBox.Show(
                            "Este material ya existe. ¿Desea actualizar el Stock Actual?",
                            "Producto existente",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            
                            productoExistente.StockActual += cantidadIngresada;

                            productoExistente.FechaUltimaModificacion = DateTime.Now;

                            context.SaveChanges();

                            MessageBox.Show("El stock ha sido actualizado correctamente.");
                            _inventarioForm.CargarProductos(); 
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se realizaron cambios en el producto.");
                        }
                    }
                    else
                    {
                        
                        MessageBox.Show(
                            "Ya existe un producto con este código, pero con un nombre diferente. Por favor, ingresa un código de producto distinto.",
                            "Código de producto duplicado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }

                   
                    return;
                }

                
                var nuevoProducto = new Producto
                {
                    CodigoProducto = codigoProducto,
                    Nombre = txtNombreProducto.Text,
                    Descripcion = txtDescripcion.Text,
                    Categoria = CategoriaBox.SelectedItem?.ToString() ?? "Sin categoría",
                    StockActual = cantidadIngresada,
                    FechaIngreso = dtpFechaIngreso.Value,
                    FechaUltimaModificacion = DateTime.Now
                };

                context.Productos.Add(nuevoProducto);
                context.SaveChanges();

                MessageBox.Show("Producto agregado correctamente.");
                LimpiarCampos();
                _inventarioForm.CargarProductos(); 
            }
        }



        private void LimpiarCampos()
        {
            txtNombreProducto.Clear();
            txtDescripcion.Clear();
            CategoriaBox.SelectedIndex = -1;
            numericCantProd.Value = 1;
            dtpFechaIngreso.Value = DateTime.Now;
        }

        private void CategoriaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void numericCantProd_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
