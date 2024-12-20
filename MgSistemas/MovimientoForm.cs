﻿using System;
using System.Linq;
using System.Windows.Forms;
using static MgSistemas.PanolContext;

namespace MgSistemas
{
    public partial class MovimientoForm : Form
    {
        private int _idProducto;
        private Usuario _usuarioActual;
        private InventarioForm _inventarioForm; // Referencia al formulario de inventario

        public MovimientoForm(int idProducto, Usuario usuario, InventarioForm inventarioForm)
        {
            InitializeComponent();
            _idProducto = idProducto;
            _usuarioActual = usuario;
            _inventarioForm = inventarioForm; // Pasar referencia del formulario de inventario
        }

        private void btnGuardarMovimiento_Click(object sender, EventArgs e)
        {
            int cantidad = (int)numericCantidad.Value;
            string detalles = txtDetalles.Text;
            DateTime fechaMovimiento = dtpFechaMovimiento.Value;

            using (var context = new PanolContext())
            {
                var producto = context.Productos.FirstOrDefault(p => p.IdProducto == _idProducto);
                if (producto != null)
                {
                    // Verificación si la cantidad solicitada es mayor al stock actual
                    if (cantidad > producto.StockActual)
                    {
                        MessageBox.Show("No hay suficiente stock disponible para realizar el retiro.", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int nuevoStock = producto.StockActual - cantidad;

                    // Verificación de advertencia si el stock quedará en 0
                    if (nuevoStock == 0)
                    {
                        var result = MessageBox.Show(
                            "El movimiento dejará el stock en 0. ¿Estás seguro de realizar el retiro?",
                            "Advertencia de Stock",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if (result == DialogResult.No)
                        {
                            // Cancelar el movimiento si el usuario selecciona "No"
                            return;
                        }
                    }

                    // Actualizar el stock del producto
                    producto.StockActual = nuevoStock;

                    // Crear el movimiento de salida
                    var movimiento = new Movimiento
                    {
                        IdProducto = _idProducto,
                        Cantidad = cantidad,
                        FechaMovimiento = fechaMovimiento,
                        TipoMovimiento = "Salida",
                        Usuario = _usuarioActual.NombreUsuario, // Usar el nombre del usuario logueado
                        Detalles = detalles
                    };

                    context.Movimientos.Add(movimiento);
                    context.SaveChanges();

                    MessageBox.Show("Movimiento registrado y stock actualizado");

                    // Actualizar el DataGridView en el formulario de inventario
                    _inventarioForm.CargarProductos();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }

            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            var inventarioForm = new InventarioForm(_usuarioActual);
            inventarioForm.Show();
            this.Close();
        }
    }
}


