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
            btnVolver = new Button();
            btnRqRealizado = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequerimientosPendientes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRequerimientosPendientes
            // 
            dataGridViewRequerimientosPendientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewRequerimientosPendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRequerimientosPendientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewRequerimientosPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRequerimientosPendientes.Location = new Point(12, 46);
            dataGridViewRequerimientosPendientes.Name = "dataGridViewRequerimientosPendientes";
            dataGridViewRequerimientosPendientes.Size = new Size(989, 363);
            dataGridViewRequerimientosPendientes.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(916, 415);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(87, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnRqRealizado
            // 
            btnRqRealizado.Location = new Point(805, 415);
            btnRqRealizado.Name = "btnRqRealizado";
            btnRqRealizado.Size = new Size(87, 23);
            btnRqRealizado.TabIndex = 2;
            btnRqRealizado.Text = "Realizado";
            btnRqRealizado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(353, 9);
            label1.Name = "label1";
            label1.Size = new Size(326, 32);
            label1.TabIndex = 3;
            label1.Text = "Requerimientos Pendientes";
            // 
            // VerRequerimientosPendientesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1013, 450);
            Controls.Add(label1);
            Controls.Add(btnRqRealizado);
            Controls.Add(btnVolver);
            Controls.Add(dataGridViewRequerimientosPendientes);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VerRequerimientosPendientesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ver Requerimientos";
            Load += VerRequerimientosPendientesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequerimientosPendientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewRequerimientosPendientes;
        private Button btnVolver;
        private Button btnRqRealizado;
        private Label label1;
    }
}

