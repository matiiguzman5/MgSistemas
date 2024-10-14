namespace MgSistemas
{
    partial class CargarMovimientos
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
            dataGridViewMovimientos = new DataGridView();
            label1 = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovimientos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMovimientos
            // 
            dataGridViewMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMovimientos.Location = new Point(12, 48);
            dataGridViewMovimientos.Name = "dataGridViewMovimientos";
            dataGridViewMovimientos.Size = new Size(776, 367);
            dataGridViewMovimientos.TabIndex = 0;
            dataGridViewMovimientos.CellContentClick += dataGridViewMovimientos_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(306, -2);
            label1.Name = "label1";
            label1.Size = new Size(187, 37);
            label1.TabIndex = 1;
            label1.Text = "Movimientos";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(656, 421);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // CargarMovimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(label1);
            Controls.Add(dataGridViewMovimientos);
            Name = "CargarMovimientos";
            Text = "CargarMovientos";
            Load += CargarMovimientos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMovimientos;
        private Label label1;
        private Button btnVolver;
    }
}