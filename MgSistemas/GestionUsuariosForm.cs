using MgSistemas;
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
                var usuarios = context.Usuarios
             .Select(u => new
             {
                 u.IdUsuario,
                 u.NombreUsuario,
                 u.NombreCompleto,
                 u.Rol,
                 u.FechaCreacion,
                 
             })
             .ToList();
                DataGridViewUsuarios.DataSource = usuarios;
            }
        }


        private void GestionUsuariosForm_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void EliminarUsuario_Click(object sender, EventArgs e)
        {
            if (DataGridViewUsuarios.CurrentRow != null)
            {
                int idUsuario = (int)DataGridViewUsuarios.CurrentRow.Cells["IdUsuario"].Value;

                var result = MessageBox.Show("¿Estas seguro de que deseas eliminar este Usuario?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (var context = new PanolContext())
                    {
                        var usuarios = context.Usuarios.FirstOrDefault(p => p.IdUsuario == idUsuario);

                        if (usuarios != null)
                        {
                            context.Usuarios.Remove(usuarios);
                            context.SaveChanges();

                            MessageBox.Show("El Usuario fue eliminado correctamente.");

                            CargarUsuarios();
                        }
                        else
                        {
                            MessageBox.Show("Por favor, selecciona un usuario para eliminar");
                        }
                    }
                }
                
            }
        }
    }
}
