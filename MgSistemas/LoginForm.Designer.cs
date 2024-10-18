namespace MgSistemas
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            txtNombreUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnIniciarSesion = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(43, 45, 66);
            label3.Location = new Point(426, 37);
            label3.Name = "label3";
            label3.Size = new Size(176, 30);
            label3.TabIndex = 2;
            label3.Text = "INICIAR SESION";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BackColor = Color.White;
            txtNombreUsuario.BorderStyle = BorderStyle.None;
            txtNombreUsuario.ForeColor = Color.FromArgb(43, 45, 66);
            txtNombreUsuario.Location = new Point(308, 90);
            txtNombreUsuario.Multiline = true;
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(408, 25);
            txtNombreUsuario.TabIndex = 3;
            txtNombreUsuario.Text = "Usuario";
            txtNombreUsuario.Enter += txtuser_Enter;
            txtNombreUsuario.Leave += txtuser_Leave;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.White;
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.ForeColor = Color.FromArgb(43, 45, 66);
            txtContraseña.Location = new Point(308, 159);
            txtContraseña.Multiline = true;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(408, 25);
            txtContraseña.TabIndex = 4;
            txtContraseña.Text = "Contraseña";
            txtContraseña.Enter += txtpass_Enter;
            txtContraseña.KeyDown += txtContraseña_KeyDown;
            txtContraseña.Leave += txtpass_Leave;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.FromArgb(239, 35, 60);
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.ForeColor = Color.FromArgb(43, 45, 66);
            btnIniciarSesion.Location = new Point(308, 214);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(408, 40);
            btnIniciarSesion.TabIndex = 5;
            btnIniciarSesion.Text = "Acceder";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(239, 35, 60);
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 6;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 244);
            ClientSize = new Size(764, 291);
            Controls.Add(panel1);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label3);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox txtNombreUsuario;
        private TextBox txtContraseña;
        private Button btnIniciarSesion;
        private Panel panel1;
    }
}