namespace MgSistemas
{
    partial class VerRequerimientosPendientesForm
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
            dataGridViewRequerimientosPendientes = new DataGridView();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequerimientosPendientes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRequerimientosPendientes
            // 
            dataGridViewRequerimientosPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRequerimientosPendientes.Location = new Point(12, 46);
            dataGridViewRequerimientosPendientes.Name = "dataGridViewRequerimientosPendientes";
            dataGridViewRequerimientosPendientes.Size = new Size(776, 363);
            dataGridViewRequerimientosPendientes.TabIndex = 0;
            dataGridViewRequerimientosPendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(642, 417);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // VerRequerimientosPendientesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnActualizar);
            Controls.Add(dataGridViewRequerimientosPendientes);
            Name = "VerRequerimientosPendientesForm";
            Text = "VerRequerimientosForm";
            Load += VerRequerimientosPendientesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequerimientosPendientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewRequerimientosPendientes;
        private Button btnActualizar;
    }
}

