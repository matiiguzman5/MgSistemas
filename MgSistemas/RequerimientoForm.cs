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
    public partial class RequerimientoForm : Form
    {
        public RequerimientoForm()
        {
            InitializeComponent();
        }

        private void RequerimientoForm_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string productosSeleccionado = comboBoxSelecProd.SelectedItem?.ToString();
            int cantidad = (int)numericUpDown1.Value;

            if (productosSeleccionado != null && cantidad > 0)
            {
                dataGridViewProductos.Rows.Add(productosSeleccionado, cantidad);
            }
            else
            {
                MessageBox.Show("Por favor selecciona un producto y una cantidad mayor a 0");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.CurrentRow != null) {
                dataGridViewProductos.Rows.Remove(dataGridViewProductos.CurrentRow);
            } else
            {
                MessageBox.Show("Por favor selecciona un producto para eliminar");
            }
        }
    }
}
