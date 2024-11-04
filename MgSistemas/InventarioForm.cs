using System.Data;
using static MgSistemas.PanolContext;




namespace MgSistemas
{
    public partial class InventarioForm : Form
    {
        private Usuario _usuarioActual;

        public InventarioForm(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void InventarioForm_Load(object sender, EventArgs e)
        {
            CargarProductos();



            dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewProductos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewProductos.RowTemplate.Height = 35;

            // Encabezado personalizado
            dataGridViewProductos.EnableHeadersVisualStyles = false;
            dataGridViewProductos.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridViewProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewProductos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridViewProductos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Bordes y líneas de separación
            dataGridViewProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewProductos.GridColor = Color.Black; // Color de las líneas de separación

            // Alternancia de color de filas
            dataGridViewProductos.DefaultCellStyle.BackColor = Color.White;
            dataGridViewProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Ocultar columna de selección
            dataGridViewProductos.RowHeadersVisible = false;

            // Configura la columna "Descripción" para que ocupe el espacio restante
            if (dataGridViewProductos.Columns.Contains("Descripcion"))
            {
                dataGridViewProductos.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewProductos.Columns["Descripcion"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            else
            {
                MessageBox.Show("La columna 'Descripcion' no se encontró en el DataGridView.");
            }

            dataGridViewProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewProductos.GridColor = Color.Black;
            dataGridViewProductos.RowTemplate.Height = 90;

            dataGridViewProductos.RowHeadersVisible = false;
        }


        public void CargarProductos()
        {
            using (var context = new PanolContext())
            {

                var productos = context.Productos.ToList();
                dataGridViewProductos.DataSource = productos;
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.CurrentRow != null)
            {
                int idProducto = (int)dataGridViewProductos.CurrentRow.Cells["IdProducto"].Value;
                var edicionForm = new EdicionForm(idProducto, _usuarioActual, this);
                edicionForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecciona un producto para editar.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchTerm = txtBuscar.Text.ToLower();

            using (var context = new PanolContext())
            {
                int codigoProducto;
                bool isNumeric = int.TryParse(searchTerm, out codigoProducto);

                var productos = context.Productos
                    .Where(p => (isNumeric && p.CodigoProducto == codigoProducto) ||
                                p.Nombre.ToLower().Contains(searchTerm) ||
                                p.Categoria.ToLower().Contains(searchTerm) ||
                                p.Descripcion.ToLower().Contains(searchTerm))
                    .ToList();

                dataGridViewProductos.DataSource = productos;
            }
        }

        private void btnVolverMainInv_Click(object sender, EventArgs e)
        {

            var mainForm = new MainForm(_usuarioActual);
            mainForm.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var agregarProductoForm = new AgregarProductoForm(this, _usuarioActual);
            agregarProductoForm.ShowDialog();

            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.CurrentRow != null)
            {
                int idProducto = (int)dataGridViewProductos.CurrentRow.Cells["IdProducto"].Value;

                var result = MessageBox.Show("¿Estas seguro de que deseas eliminar este producto?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result == DialogResult.Yes)
                {
                    using (var context = new PanolContext())
                    {
                        var producto = context.Productos.FirstOrDefault(p => p.IdProducto == idProducto);

                        if (producto != null)
                        {
                            var movimientoEliminacion = new Movimiento
                            {
                                IdProducto = producto.IdProducto,
                                Cantidad = producto.StockActual, // Registrar la cantidad que se está eliminando
                                FechaMovimiento = DateTime.Now,
                                TipoMovimiento = "Eliminación",
                                Usuario = _usuarioActual.NombreUsuario, // Usuario que realiza la eliminación
                                Detalles = "Producto eliminado del inventario"
                            };

                            context.Movimientos.Add(movimientoEliminacion);

                            context.Productos.Remove(producto);
                            context.SaveChanges();

                            MessageBox.Show("El producto fue eliminado correctamente.");

                            CargarProductos();
                        }
                        else
                        {
                            MessageBox.Show("Por favor, selecciona un producto para eliminar.");
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMoviento_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.CurrentRow != null)
            {
                int idProducto = (int)dataGridViewProductos.CurrentRow.Cells["IdProducto"].Value;
                var movimientoForm = new MovimientoForm(idProducto, _usuarioActual, this);
                movimientoForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para gestionar el movimiento");
            }


        }

        private void btnVerMovimientos_Click(object sender, EventArgs e)
        {

            if (dataGridViewProductos.CurrentRow != null)
            {

                var cargarMovimientos = new CargarMovimientos(_usuarioActual);
                cargarMovimientos.Show();


                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para ver sus movimientos.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
