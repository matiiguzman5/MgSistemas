using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using static MgSistemas.PanolContext;

namespace MgSistemas
{
    public partial class VerRequerimientosPendientesForm : Form
    {
        private Usuario _usuarioActual;
        public VerRequerimientosPendientesForm(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
        }

        private void VerRequerimientosPendientesForm_Load(object sender, EventArgs e)
        {
            CargarRequerimientosPendientes();
        }

        private void CargarRequerimientosPendientes()
        {


            using (var context = new PanolContext())
            {

                var requerimientosPendientes = context.Requerimientos
                .Include(r => r.Productos)
                .Select(r => new
                {
                    r.NroRequerimiento,
                    r.Responsable,
                    r.FechaEntrega,
                    r.Observaciones,
                    Productos = string.Join(", ", r.Productos.Select(p => $"{p.Producto.Nombre} (Cantidad: {p.Cantidad})"))
                })
                .ToList();

                if (requerimientosPendientes.Count == 0)
                {
                    MessageBox.Show("No hay requerimientos pendientes.");
                    this.Close();

                }
                else
                {
                    dataGridViewRequerimientosPendientes.DataSource = requerimientosPendientes;
                }

                dataGridViewRequerimientosPendientes.DataSource = requerimientosPendientes;


                dataGridViewRequerimientosPendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm(_usuarioActual);
            mainForm.Show();
            this.Hide();
        }
    }
}
