using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static MgSistemas.PanolContext;

namespace MgSistemas
{
    public partial class AgregarUsuarioForm : Form
    {
        private Usuario _usuarioActual;
        public AgregarUsuarioForm(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContrasenia.Text) ||
                string.IsNullOrWhiteSpace(txtNombreCompleto.Text) ||
                cmbRol.SelectedItem == null)
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new PanolContext())
            {

                var usuarioExistente = context.Usuarios
                    .FirstOrDefault(u => u.NombreUsuario == txtNombreUsuario.Text);

                if (usuarioExistente != null)
                {
                    MessageBox.Show("Ya existe un usuario con este nombre de usuario. Por favor, elige otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var nuevoUsuario = new Usuario
                {
                    NombreUsuario = txtNombreUsuario.Text,
                    Contrasenia = EncriptarContraseña(txtContrasenia.Text),
                    NombreCompleto = txtNombreCompleto.Text,
                    Rol = cmbRol.SelectedItem.ToString(),
                    FechaCreacion = DateTime.Now,
                    Activo = true
                };

                context.Usuarios.Add(nuevoUsuario);
                context.SaveChanges();

                MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();

            }
        }

        // Método para encriptar la contraseña.
        private string EncriptarContraseña(string contrasenia)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(contrasenia));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtNombreUsuario.Clear();
            txtContrasenia.Clear();
            txtNombreCompleto.Clear();
            cmbRol.SelectedIndex = -1;
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var GestionUsuariosForm = new GestionUsuariosForm(_usuarioActual);
            GestionUsuariosForm.Show();

            this.Close();    
        }
    }
}
