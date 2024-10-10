namespace MgSistemas
{
    partial class GestionUsuariosForm
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
            DataGridViewUsuarios = new DataGridView();
            label1 = new Label();
            btnAgregarUsuario = new Button();
            EditarUsuario = new Button();
            EliminarUsuario = new Button();
            btnVolver1 = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewUsuarios).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewUsuarios
            // 
            DataGridViewUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewUsuarios.Location = new Point(12, 46);
            DataGridViewUsuarios.Name = "DataGridViewUsuarios";
            DataGridViewUsuarios.Size = new Size(776, 352);
            DataGridViewUsuarios.TabIndex = 0;
            DataGridViewUsuarios.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 1;
            label1.Text = "Gestion de Usuarios";
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(279, 13);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(107, 23);
            btnAgregarUsuario.TabIndex = 2;
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // EditarUsuario
            // 
            EditarUsuario.Location = new Point(425, 13);
            EditarUsuario.Name = "EditarUsuario";
            EditarUsuario.Size = new Size(107, 23);
            EditarUsuario.TabIndex = 3;
            EditarUsuario.Text = "Editar Usuario";
            EditarUsuario.UseVisualStyleBackColor = true;
            // 
            // EliminarUsuario
            // 
            EliminarUsuario.Location = new Point(569, 13);
            EliminarUsuario.Name = "EliminarUsuario";
            EliminarUsuario.Size = new Size(107, 23);
            EliminarUsuario.TabIndex = 4;
            EliminarUsuario.Text = "Eliminar Usuario";
            EliminarUsuario.UseVisualStyleBackColor = true;
            EliminarUsuario.Click += EliminarUsuario_Click;
            // 
            // btnVolver1
            // 
            btnVolver1.Location = new Point(658, 404);
            btnVolver1.Name = "btnVolver1";
            btnVolver1.Size = new Size(130, 34);
            btnVolver1.TabIndex = 5;
            btnVolver1.Text = "Volver";
            btnVolver1.UseVisualStyleBackColor = true;
            btnVolver1.Click += btnVolver1_Click;
            // 
            // GestionUsuariosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver1);
            Controls.Add(EliminarUsuario);
            Controls.Add(EditarUsuario);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(label1);
            Controls.Add(DataGridViewUsuarios);
            Name = "GestionUsuariosForm";
            Text = "GestionUsuariosForm";
            Load += GestionUsuariosForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridViewUsuarios;
        private Label label1;
        private Button btnAgregarUsuario;
        private Button EditarUsuario;
        private Button EliminarUsuario;
        private Button btnVolver1;
    }
}