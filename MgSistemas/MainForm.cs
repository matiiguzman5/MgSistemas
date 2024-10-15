using static MgSistemas.PanolContext;

namespace MgSistemas
{
    public partial class MainForm : Form
    {

        private Usuario _usuarioActual;

        public MainForm(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;


        }

        private void verInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
                MessageBox.Show("No tienes permisos para acceder a esta funcion.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicacion?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
    }
}
