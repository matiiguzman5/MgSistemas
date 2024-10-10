using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MgSistemas.PanolContext;

namespace MgSistemas
{
       
    public partial class GestionUsuariosForm : Form
    {
        private Usuario _usuarioActual;
        public GestionUsuariosForm(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;

        }

        private void CargarUsuarios()
        {
            using (var context = new PanolContext())
            {
                var Usuario = context.Usuarios.Select(u => new
                {
                    u.IdUsuario,
                    u.NombreUsuario,
                    u.NombreCompleto,
                    u.Rol
                }).ToList();

                DataGridViewUsuarios.DataSource = Usuario;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarUsuarios();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            var AgregarUsuarioForm = new AgregarUsuarioForm(_usuarioActual);
            AgregarUsuarioForm.Show();

            this.Close();
        }

        private void btnVolver1_Click(object sender, EventArgs e)
        {
            var MainForm = new MainForm(_usuarioActual);
            MainForm.Show();
            this.Close();
        }
    }
}
