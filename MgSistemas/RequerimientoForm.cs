using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static MgSistemas.PanolContext;

namespace MgSistemas
{
    
    public partial class RequerimientoForm : Form
    {

        private Usuario _usuarioActual;
        public RequerimientoForm(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
        }

        private void RequerimientoForm_Load(object sender, EventArgs e)
        {


            groupBoxRequerimiento.Enabled = false;
            groupBox3.Enabled = false;


            btnNuevoRq.Enabled = true;


            using (var context = new PanolContext())
            {

                var productos = context.Productos.ToList();
                comboBoxSelecProd.DataSource = productos;
                comboBoxSelecProd.DisplayMember = "Nombre";
                comboBoxSelecProd.ValueMember = "IdProducto";


                var usuarios = context.Usuarios.Where(u => u.Activo == true).ToList();
                comboBoxUsers.DataSource = usuarios;
                comboBoxUsers.DisplayMember = "NombreUsuario";
                comboBoxUsers.ValueMember = "IdUsuario";
                comboBoxUsers.SelectedIndex = -1;
            }
        }




        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var producto = (Producto)comboBoxSelecProd.SelectedItem;
            int cantidad = (int)numericCantidad.Value;

            if (producto == null || cantidad <= 0)
            {
                MessageBox.Show("Por favor, selecciona un producto y una cantidad válida.");
                return;
            }

            // Agregar el CódigoProducto como una columna oculta y el nombre del producto y cantidad como visibles
            dataGridViewProductos.Rows.Add(producto.CodigoProducto, producto.Nombre, cantidad);

            comboBoxSelecProd.SelectedIndex = -1;
            numericCantidad.Value = 0;
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.CurrentRow != null)
            {
                dataGridViewProductos.Rows.Remove(dataGridViewProductos.CurrentRow);
            }
            else
            {
                MessageBox.Show("Por favor selecciona un producto para eliminar");
            }
        }

        private void btnNuevoRq_Click(object sender, EventArgs e)
        {
            groupBoxRequerimiento.Enabled = true;
            txtNroRequerimiento.Text = "";
            txtObservaciones.Clear();
            dtpFechaSolicitud.Value = DateTime.Now;

            dataGridViewProductos.Rows.Clear();

            btnAgregar.Enabled = true;
            btnEliminar.Enabled = true;

            MessageBox.Show("Listo para crear un nuevo requerimiento.");
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (dataGridViewProductos.Rows.Count == 0 || dataGridViewProductos.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Debe agregar al menos un producto antes de generar el requerimiento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxUsers.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un responsable.");
                return;
            }

            if (dtpFechaSolicitud.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Debe seleccionar una fecha de entrega.");
                return;
            }

            try
            {
                using (var context = new PanolContext())
                {
                    // Generar el número de requerimiento automáticamente
                    int nuevoNroRequerimiento = context.Requerimientos.Any()
                        ? context.Requerimientos.Max(r => r.NroRequerimiento) + 1
                        : 1;

                    var nuevoRequerimiento = new Requerimiento
                    {
                        NroRequerimiento = nuevoNroRequerimiento,
                        Responsable = comboBoxUsers.Text,
                        FechaEntrega = dtpFechaSolicitud.Value,
                        Observaciones = txtObservaciones.Text,
                        Prioridad = rbtnNormal.Checked ? "Normal" : "Alta",
                        Productos = new List<ProductoRequerido>()
                    };


                    if (dataGridViewProductos.Rows.Count == 0)
                    {
                        MessageBox.Show("Debe agregar al menos un producto.");
                        return;
                    }


                    foreach (DataGridViewRow row in dataGridViewProductos.Rows)
                    {
                        if (row.Cells["CodigoProducto"].Value != null && row.Cells["Cantidad"].Value != null)
                        {

                            var codigoProducto = (int)row.Cells["CodigoProducto"].Value;
                            var producto = context.Productos.FirstOrDefault(p => p.CodigoProducto == codigoProducto);

                            if (producto != null)
                            {
                                var productoRequerido = new ProductoRequerido
                                {
                                    IdProducto = producto.IdProducto,
                                    Cantidad = (int)row.Cells["Cantidad"].Value
                                };

                                nuevoRequerimiento.Productos.Add(productoRequerido);
                            }
                        }
                    }

                    context.Requerimientos.Add(nuevoRequerimiento);
                    context.SaveChanges();

                    // Mensaje de confirmación y opción de exportar a PDF
                    var result = MessageBox.Show($"Requerimiento N° {nuevoNroRequerimiento} generado correctamente. ¿Desea exportarlo a PDF?", "Requerimiento Generado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        ExportarRequerimientoAPDF(nuevoRequerimiento);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void ExportarRequerimientoAPDF(Requerimiento requerimiento)
        {
            // Ruta del archivo donde se guardará el PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                FileName = $"Requerimiento_{requerimiento.NroRequerimiento}.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Crear el archivo PDF
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        Document doc = new Document(PageSize.A4);
                        PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                        doc.Open();


                        var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                        doc.Add(new Paragraph($"Requerimiento N° {requerimiento.NroRequerimiento}", titleFont));
                        doc.Add(new Paragraph(" "));


                        var bodyFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                        doc.Add(new Paragraph($"Responsable: {requerimiento.Responsable}", bodyFont));
                        doc.Add(new Paragraph($"Fecha de Entrega: {requerimiento.FechaEntrega.ToShortDateString()}", bodyFont));
                        doc.Add(new Paragraph($"Prioridad: {requerimiento.Prioridad}", bodyFont));
                        doc.Add(new Paragraph($"Observaciones: {requerimiento.Observaciones}", bodyFont));
                        doc.Add(new Paragraph(" "));


                        PdfPTable table = new PdfPTable(3);
                        table.AddCell("Código Producto");
                        table.AddCell("Producto");
                        table.AddCell("Cantidad");

                        foreach (var producto in requerimiento.Productos)
                        {
                            table.AddCell(producto.IdProducto.ToString());
                            table.AddCell(producto.Producto.Nombre);
                            table.AddCell(producto.Cantidad.ToString());
                        }

                        doc.Add(table);
                        doc.Close();
                    }

                    MessageBox.Show("Requerimiento exportado a PDF correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al generar el PDF: {ex.Message}");
                }

            }
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxSelecProd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxRequerimiento_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm(_usuarioActual);
            mainForm.Show();
            this.Close();
        }
    }
}
