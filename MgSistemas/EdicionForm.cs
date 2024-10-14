using System;
using System.Linq;
using System.Windows.Forms;
using static MgSistemas.PanolContext;

namespace MgSistemas
{
    public partial class EdicionForm : Form
    {
        private int _idProducto;
        private Usuario _usuarioActual;
        private InventarioForm _inventarioForm;

        public EdicionForm(int idProducto, Usuario usuarioActual, InventarioForm inventarioForm)
        {
            InitializeComponent();
            _idProducto = idProducto;
            _usuarioActual = usuarioActual;
            _inventarioForm = inventarioForm;

            // Cargar datos del producto al abrir el formulario
            CargarDatosProducto(_idProducto);
        }

        private void CargarDatosProducto(int idProducto)
        {
            using (var context = new PanolContext())
            {
                var producto = context.Productos.FirstOrDefault(p => p.IdProducto == idProducto);

                if (producto != null)
                {
                    // Cargar los valores en los controles
                    txtNombreProducto.Text = producto.Nombre;
                    txtDescripcion.Text = producto.Descripcion;
                    numericCantProd.Value = producto.StockActual;
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                    this.Close(); // Cerrar el formulario si no se encuentra el producto
                }
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            using (var context = new PanolContext())
            {
                var producto = context.Productos.FirstOrDefault(p => p.IdProducto == _idProducto);

                if (producto != null)
                {
                    // Variables para trackear los cambios
                    bool cambiosRealizados = false;
                    string detallesMovimiento = "Modificaciones: ";

                    // Verificar si cambió el nombre del producto
                    if (producto.Nombre != txtNombreProducto.Text)
                    {
                        detallesMovimiento += $"Nombre cambiado de {producto.Nombre} a {txtNombreProducto.Text}. ";
                        producto.Nombre = txtNombreProducto.Text;
                        cambiosRealizados = true;
                    }

                    // Verificar si cambió la descripción del producto
                    if (producto.Descripcion != txtDescripcion.Text)
                    {
                        detallesMovimiento += $"Descripción cambiada. ";
                        producto.Descripcion = txtDescripcion.Text;
                        cambiosRealizados = true;
                    }

                    // Verificar si se agregó o redujo stock
                    int nuevaCantidad = (int)numericCantProd.Value;
                    if (nuevaCantidad != producto.StockActual)
                    {
                        int diferenciaStock = nuevaCantidad - producto.StockActual;
                        detallesMovimiento += diferenciaStock > 0 ? $"Stock incrementado en {diferenciaStock}. " : $"Stock reducido en {-diferenciaStock}. ";
                        producto.StockActual = nuevaCantidad;
                        cambiosRealizados = true;
                    }

                    if (cambiosRealizados)
                    {
                        producto.FechaUltimaModificacion = DateTime.Now;

                        // Agregar registro en la tabla de movimientos
                        var movimiento = new Movimiento
                        {
                            IdProducto = _idProducto,
                            Cantidad = nuevaCantidad, // Agregar la cantidad nueva
                            FechaMovimiento = DateTime.Now,
                            TipoMovimiento = "Modificación",
                            Usuario = _usuarioActual.NombreUsuario, // Usuario que realizó el cambio
                            Detalles = detallesMovimiento
                        };

                        context.Movimientos.Add(movimiento);
                        context.SaveChanges();

                        MessageBox.Show("Producto actualizado y movimiento registrado.");
                        _inventarioForm.CargarProductos();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se realizaron cambios.");
                    }
                }
            }
        }
    }
}
