using static MgSistemas.PanolContext;
using System.Drawing;

namespace MgSistemas
{
    public partial class MainForm : Form
    {
        private Usuario _usuarioActual;

        public MainForm(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;

            // Personalizar el MenuStrip
            PersonalizarMenuStrip();
        }

        private void PersonalizarMenuStrip()
        {
            // Cambiar colores del MenuStrip
            menuStrip1.BackColor = Color.LightSlateGray;
            menuStrip1.ForeColor = Color.White;
            menuStrip1.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            // Separar con separadores
            menuStrip1.Items.Insert(1, new ToolStripSeparator());

        }

        private void verInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Implementación
        }

        private void verInventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var inventarioForm = new InventarioForm(_usuarioActual);
            inventarioForm.Show();
            this.Hide();
        }

        private void administrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_usuarioActual.Rol == "Administrador")
            {
                var GestionUsuarioForm = new GestionUsuariosForm(_usuarioActual);
                GestionUsuarioForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a esta función.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicación?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void desloguearseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estás seguro de que deseas cerrar la sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        private void generarRequerimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var RequerimientoForm = new RequerimientoForm(_usuarioActual);
            RequerimientoForm.Show();
            this.Close();
        }

        private void verRQPendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var VerRequerimientosPendientesForm = new VerRequerimientosPendientesForm(_usuarioActual);
            VerRequerimientosPendientesForm.Show();
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Evento load para futuras personalizaciones
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void verProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ProveedoresForm = new ProveedoresForm();
            ProveedoresForm.Show();
            this.Close();
        }
    }
}
