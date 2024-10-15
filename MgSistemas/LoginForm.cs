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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string contrasenia = txtContraseña.Text;

            using (var context = new PanolContext())
            {
                var usuario = context.Usuarios
                    .FirstOrDefault(u => u.NombreUsuario == nombreUsuario);

                if (usuario != null && VerificarContrasenia(contrasenia, usuario.Contrasenia))
                {
                    MessageBox.Show("Inicio de sesión exitoso.");

                    var mainForm = new MainForm(usuario);
                    mainForm.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrecto.");
                }
            }
        }
        private bool VerificarContrasenia(string contraseniaIngresada, string contraseniaAlmacenada)
        {
            // Hasheamos la contraseña ingresada utilizando el mismo método que se usó para almacenarla.
            string contraseniaHasheada = EncriptarContraseña(contraseniaIngresada);

            // Comparamos la contraseña hasheada con la almacenada.
            return contraseniaHasheada == contraseniaAlmacenada;
        }
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
    }

}
