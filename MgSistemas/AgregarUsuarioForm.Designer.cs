namespace MgSistemas
{
    partial class AgregarUsuarioForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombreUsuario = new TextBox();
            txtContrasenia = new TextBox();
            txtNombreCompleto = new TextBox();
            cmbRol = new ComboBox();
            btnAgregarUsuario = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 120);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(262, 169);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(262, 217);
            label3.Name = "label3";
            label3.Size = new Size(140, 21);
            label3.TabIndex = 2;
            label3.Text = "Nombre Completo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(262, 272);
            label4.Name = "label4";
            label4.Size = new Size(33, 21);
            label4.TabIndex = 3;
            label4.Text = "Rol";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(302, 35);
            label5.Name = "label5";
            label5.Size = new Size(198, 37);
            label5.TabIndex = 4;
            label5.Text = "Crear Usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(411, 120);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(114, 23);
            txtNombreUsuario.TabIndex = 5;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(411, 171);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(114, 23);
            txtContrasenia.TabIndex = 6;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(411, 219);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(114, 23);
            txtNombreCompleto.TabIndex = 7;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Administrador", "Empleado" });
            cmbRol.Location = new Point(411, 272);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(114, 23);
            cmbRol.TabIndex = 8;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(312, 336);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(164, 48);
            btnAgregarUsuario.TabIndex = 9;
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(582, 336);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 48);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // AgregarUsuarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(cmbRol);
            Controls.Add(txtNombreCompleto);
            Controls.Add(txtContrasenia);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarUsuarioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Usuario ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombreUsuario;
        private TextBox txtContrasenia;
        private TextBox txtNombreCompleto;
        private ComboBox cmbRol;
        private Button btnAgregarUsuario;
        private Button btnVolver;
    }
}