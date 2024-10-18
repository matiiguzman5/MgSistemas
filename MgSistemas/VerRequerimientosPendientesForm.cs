using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace MgSistemas
{
    public partial class VerRequerimientosPendientesForm : Form
    {
        public VerRequerimientosPendientesForm()
        {
            InitializeComponent();
        }

        private void VerRequerimientosPendientesForm_Load(object sender, EventArgs e)
        {
            CargarRequerimientosPendientes();
        }

        private void CargarRequerimientosPendientes()
        {
            using (var context = new PanolContext())
            {
                // Obtener los requerimientos pendientes y sus productos
                var requerimientosPendientes = context.Requerimientos
                    .Include(r => r.Productos)
                    .Where(r => r.FechaEntrega >= DateTime.Now)
                    .Select(r => new
                    {
                        r.NroRequerimiento,
                        r.Responsable,
                        r.FechaEntrega,
                        r.Observaciones,
                        Productos = string.Join(", ", r.Productos.Select(p => $"{p.Producto.Nombre} (Cantidad: {p.Cantidad})"))
                    })
                    .ToList();

                // Llenar el DataGridView con los requerimientos pendientes
                dataGridViewRequerimientosPendientes.DataSource = requerimientosPendientes;

                // Ajustar el ancho de las columnas si es necesario
                dataGridViewRequerimientosPendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarRequerimientosPendientes(); // Actualizar la lista al presionar el botón de actualización
        }
    }
}
