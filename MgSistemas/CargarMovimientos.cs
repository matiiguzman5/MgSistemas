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
    public partial class CargarMovimientos : Form

    {
        private Usuario _usuarioActual;
        public CargarMovimientos(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
        }

        private void CargarMovimientos_Load(object sender, EventArgs e)
        {
            CargarDatosMovimientos();
        }

        private void CargarDatosMovimientos()
        {
            using (var context = new PanolContext())
            {
                var movimientos = context.Movimientos
                    .Select(m => new
                    {
                        m.IdProducto,
                        m.Cantidad,
                        m.FechaMovimiento,
                        m.TipoMovimiento,
                        m.Usuario,
                        m.Detalles
                    })
                    .ToList();

                if (movimientos.Count > 0)
                {
                    MessageBox.Show("Movimientos cargados: " + movimientos.Count);
                }
                else
                {
                    MessageBox.Show("No se encontraron movimientos.");
                }

                dataGridViewMovimientos.DataSource = movimientos;
            }
        }

        private void dataGridViewMovimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewMovimientos.Columns["IdProducto"].HeaderText = "Código del Producto";
            dataGridViewMovimientos.Columns["Cantidad"].HeaderText = "Cantidad";
            dataGridViewMovimientos.Columns["FechaMovimiento"].HeaderText = "Fecha de Movimiento";
            dataGridViewMovimientos.Columns["TipoMovimiento"].HeaderText = "Tipo de Movimiento";
            dataGridViewMovimientos.Columns["Usuario"].HeaderText = "Usuario";
            dataGridViewMovimientos.Columns["Detalles"].HeaderText = "Detalles";


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var inventarioForm = new InventarioForm(_usuarioActual);
            inventarioForm.Show();
            this.Close();
        }
    }
}
