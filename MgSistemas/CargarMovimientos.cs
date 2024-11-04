using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
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
            ConfigurarControlesDeFiltrado();
            ConfigurarDataGridView();
            ConfigurarBotonVolver();
        }

        private void ConfigurarControlesDeFiltrado()
        {
            Panel panelFiltros = new Panel
            {
                Dock = DockStyle.Top,
                Height = 70
            };
            this.Controls.Add(panelFiltros);

            int startX = 20;
            int startY = 10;
            int controlSpacing = 150;
            int labelWidth = 80;

            // Label y ComboBox para Tipo de Movimiento
            Label lblTipoMovimiento = new Label
            {
                Text = "Tipo de:",
                Location = new System.Drawing.Point(startX, startY),
                Width = labelWidth
            };
            panelFiltros.Controls.Add(lblTipoMovimiento);

            ComboBox cmbTipoMovimiento = new ComboBox
            {
                Location = new System.Drawing.Point(startX + labelWidth, startY),
                Width = controlSpacing
            };
            cmbTipoMovimiento.Items.AddRange(new string[] { "Todos", "Salida", "Entrada", "Modificación", "Eliminación", "Agregar" });
            cmbTipoMovimiento.SelectedIndex = 0;
            panelFiltros.Controls.Add(cmbTipoMovimiento);

            // Label y ComboBox para Usuario
            Label lblUsuario = new Label
            {
                Text = "Usuario:",
                Location = new System.Drawing.Point(startX + 2 * controlSpacing + labelWidth + 10, startY),
                Width = labelWidth
            };
            panelFiltros.Controls.Add(lblUsuario);

            ComboBox cmbUsuario = new ComboBox
            {
                Location = new System.Drawing.Point(startX + 2 * controlSpacing + 2 * labelWidth + 10, startY),
                Width = controlSpacing
            };
            using (var context = new PanolContext())
            {
                var usuarios = context.Usuarios.Select(u => u.NombreUsuario).ToList();
                cmbUsuario.Items.Add("Todos");
                cmbUsuario.Items.AddRange(usuarios.ToArray());
                cmbUsuario.SelectedIndex = 0;
            }
            panelFiltros.Controls.Add(cmbUsuario);

            // Labels y DateTimePickers para fechas Desde y Hasta
            Label lblDesde = new Label
            {
                Text = "Desde:",
                Location = new System.Drawing.Point(startX, startY + 30),
                Width = labelWidth
            };
            panelFiltros.Controls.Add(lblDesde);

            DateTimePicker dtpFechaDesde = new DateTimePicker
            {
                Location = new System.Drawing.Point(startX + labelWidth, startY + 30),
                Width = controlSpacing,
                Format = DateTimePickerFormat.Short,
                Value = DateTime.Now.AddMonths(-1)
            };
            panelFiltros.Controls.Add(dtpFechaDesde);

            Label lblHasta = new Label
            {
                Text = "Hasta:",
                Location = new System.Drawing.Point(startX + 2 * controlSpacing + labelWidth + 10, startY + 30),
                Width = labelWidth
            };
            panelFiltros.Controls.Add(lblHasta);

            DateTimePicker dtpFechaHasta = new DateTimePicker
            {
                Location = new System.Drawing.Point(startX + 2 * controlSpacing + 2 * labelWidth + 10, startY + 30),
                Width = controlSpacing,
                Format = DateTimePickerFormat.Short,
                Value = DateTime.Now
            };
            panelFiltros.Controls.Add(dtpFechaHasta);

            // Botón de Filtrar
            Button btnFiltrar = new Button
            {
                Text = "Filtrar",
                Location = new System.Drawing.Point(startX + 3 * controlSpacing + 2 * labelWidth + 20, startY),
                Width = 80
            };
            btnFiltrar.Click += (s, e) => FiltrarMovimientos(
                cmbTipoMovimiento.SelectedItem.ToString(),
                dtpFechaDesde.Value,
                dtpFechaHasta.Value,
                cmbUsuario.SelectedItem.ToString()
            );
            panelFiltros.Controls.Add(btnFiltrar);

            // Botón de Limpiar Filtros
            Button btnLimpiarFiltros = new Button
            {
                Text = "Limpiar",
                Location = new System.Drawing.Point(startX + 3 * controlSpacing + 2 * labelWidth + 20, startY + 30),
                Width = 80
            };
            btnLimpiarFiltros.Click += (s, e) => LimpiarFiltros(cmbTipoMovimiento, cmbUsuario, dtpFechaDesde, dtpFechaHasta);
            panelFiltros.Controls.Add(btnLimpiarFiltros);
        }

        private void FiltrarMovimientos(string tipoMovimiento, DateTime fechaDesde, DateTime fechaHasta, string usuario)
        {
            using (var context = new PanolContext())
            {
                var query = context.Movimientos.AsQueryable();

                if (tipoMovimiento != "Todos")
                {
                    query = query.Where(m => m.TipoMovimiento == tipoMovimiento);
                }

                query = query.Where(m => m.FechaMovimiento >= fechaDesde && m.FechaMovimiento <= fechaHasta);

                if (usuario != "Todos")
                {
                    query = query.Where(m => m.Usuario == usuario);
                }

                var movimientos = query.Select(m => new
                {
                    CódigoProducto = m.IdProducto,
                    Cantidad = m.Cantidad,
                    FechaMovimiento = m.FechaMovimiento.ToString("dd/MM/yyyy HH:mm"),
                    TipoMovimiento = m.TipoMovimiento,
                    Usuario = m.Usuario,
                    Detalles = m.Detalles
                }).ToList();

                dataGridViewMovimientos.DataSource = movimientos;
            }
        }

        private void LimpiarFiltros(ComboBox cmbTipoMovimiento, ComboBox cmbUsuario, DateTimePicker dtpFechaDesde, DateTimePicker dtpFechaHasta)
        {
            cmbTipoMovimiento.SelectedIndex = 0;
            cmbUsuario.SelectedIndex = 0;
            dtpFechaDesde.Value = DateTime.Now.AddMonths(-1);
            dtpFechaHasta.Value = DateTime.Now;
            CargarDatosMovimientos();
        }

        private void ConfigurarDataGridView()
        {
            dataGridViewMovimientos.Dock = DockStyle.Fill;
            dataGridViewMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewMovimientos.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewMovimientos.EnableHeadersVisualStyles = false;
            dataGridViewMovimientos.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridViewMovimientos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewMovimientos.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewMovimientos.Font, FontStyle.Bold);
            dataGridViewMovimientos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        private void ConfigurarBotonVolver()
        {
            Panel panelInferior = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 50
            };
            this.Controls.Add(panelInferior);

            Button btnVolver = new Button
            {
                Text = "Volver",
                Dock = DockStyle.Left,
                Width = 100
            };
            btnVolver.Click += (sender, e) =>
            {
                var inventarioForm = new InventarioForm(_usuarioActual);
                inventarioForm.Show();
                this.Close();
            };
            panelInferior.Controls.Add(btnVolver);
        }

        private void CargarMovimientos_Load(object sender, EventArgs e)
        {
            CargarDatosMovimientos();
        }

        private void CargarDatosMovimientos()
        {
            FiltrarMovimientos("Todos", DateTime.Now.AddMonths(-1), DateTime.Now, "Todos");
        }
    }
}
