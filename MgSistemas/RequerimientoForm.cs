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

                        // Fuentes
                        var headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                        var subHeaderFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                        var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                        var tableHeaderFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);

                        // Encabezado del documento
                        PdfPTable headerTable = new PdfPTable(2);
                        headerTable.WidthPercentage = 100;
                        headerTable.SetWidths(new float[] { 1, 1 });

                        PdfPCell companyCell = new PdfPCell(new Phrase("Nombre de la Compañía", headerFont))
                        {
                            Border = 0,
                            HorizontalAlignment = Element.ALIGN_LEFT
                        };
                        headerTable.AddCell(companyCell);

                        PdfPCell titleCell = new PdfPCell(new Phrase("ORDEN DE REQUERIMIENTO", headerFont))
                        {
                            Border = 0,
                            HorizontalAlignment = Element.ALIGN_RIGHT
                        };
                        headerTable.AddCell(titleCell);

                        doc.Add(headerTable);
                        doc.Add(new Paragraph(" ")); 

                        // Información de la compañía
                        PdfPTable companyInfoTable = new PdfPTable(1);
                        companyInfoTable.WidthPercentage = 100;
                        companyInfoTable.AddCell(new PdfPCell(new Phrase("Dirección: Calle Falsa 123, Ciudad", normalFont)) { Border = 0 });
                        companyInfoTable.AddCell(new PdfPCell(new Phrase("Teléfono: 1234-5678 | Email: contacto@empresa.com", normalFont)) { Border = 0 });

                        doc.Add(companyInfoTable);
                        doc.Add(new Paragraph(" ")); // Espacio

                        // Información del requerimiento
                        PdfPTable requestInfoTable = new PdfPTable(2);
                        requestInfoTable.WidthPercentage = 100;
                        requestInfoTable.SetWidths(new float[] { 1, 3 });

                        requestInfoTable.AddCell(new PdfPCell(new Phrase("N° Requerimiento:", subHeaderFont)) { Border = 0 });
                        requestInfoTable.AddCell(new PdfPCell(new Phrase(requerimiento.NroRequerimiento.ToString(), normalFont)) { Border = 0 });

                        requestInfoTable.AddCell(new PdfPCell(new Phrase("Responsable:", subHeaderFont)) { Border = 0 });
                        requestInfoTable.AddCell(new PdfPCell(new Phrase(requerimiento.Responsable, normalFont)) { Border = 0 });

                        requestInfoTable.AddCell(new PdfPCell(new Phrase("Fecha de Entrega:", subHeaderFont)) { Border = 0 });
                        requestInfoTable.AddCell(new PdfPCell(new Phrase(requerimiento.FechaEntrega.ToShortDateString(), normalFont)) { Border = 0 });

                        requestInfoTable.AddCell(new PdfPCell(new Phrase("Prioridad:", subHeaderFont)) { Border = 0 });
                        requestInfoTable.AddCell(new PdfPCell(new Phrase(requerimiento.Prioridad, normalFont)) { Border = 0 });

                        requestInfoTable.AddCell(new PdfPCell(new Phrase("Observaciones:", subHeaderFont)) { Border = 0 });
                        requestInfoTable.AddCell(new PdfPCell(new Phrase(requerimiento.Observaciones, normalFont)) { Border = 0 });

                        doc.Add(requestInfoTable);
                        doc.Add(new Paragraph(" ")); 

                        // Tabla de productos
                        PdfPTable productTable = new PdfPTable(3);
                        productTable.WidthPercentage = 100;
                        productTable.SetWidths(new float[] { 1, 4, 1 });

                        productTable.AddCell(new PdfPCell(new Phrase("Código Producto", tableHeaderFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                        productTable.AddCell(new PdfPCell(new Phrase("Descripción del Producto", tableHeaderFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                        productTable.AddCell(new PdfPCell(new Phrase("Cantidad", tableHeaderFont)) { HorizontalAlignment = Element.ALIGN_CENTER });

                        foreach (var producto in requerimiento.Productos)
                        {
                            productTable.AddCell(new PdfPCell(new Phrase(producto.IdProducto.ToString(), normalFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                            productTable.AddCell(new PdfPCell(new Phrase(producto.Producto.Nombre, normalFont)) { HorizontalAlignment = Element.ALIGN_LEFT });
                            productTable.AddCell(new PdfPCell(new Phrase(producto.Cantidad.ToString(), normalFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                        }

                        doc.Add(productTable);

                        
                        doc.Add(new Paragraph(" "));

                        PdfPTable signatureTable = new PdfPTable(2);
                        signatureTable.WidthPercentage = 100;
                        signatureTable.SetWidths(new float[] { 1, 1 });

                        PdfPCell dateCell = new PdfPCell(new Phrase("Fecha: _________________________", normalFont))
                        {
                            Border = PdfPCell.NO_BORDER,
                            HorizontalAlignment = Element.ALIGN_LEFT,
                            PaddingTop = 500 
                        };
                        signatureTable.AddCell(dateCell);

                        PdfPCell signatureCell = new PdfPCell(new Phrase("Firma Responsable: _________________________", normalFont))
                        {
                            Border = PdfPCell.NO_BORDER,
                            HorizontalAlignment = Element.ALIGN_RIGHT,
                            PaddingTop = 500 
                        };
                        signatureTable.AddCell(signatureCell);

                        doc.Add(signatureTable);

                        // Cerrar el documento
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
