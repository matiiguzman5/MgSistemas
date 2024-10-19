namespace MgSistemas
{
    partial class MovimientoForm
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
            txtDetalles = new TextBox();
            dtpFechaMovimiento = new DateTimePicker();
            btnGuardarMovimiento = new Button();
            label2 = new Label();
            label3 = new Label();
            btnVolver = new Button();
            numericCantidad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            label1.Location = new Point(277, 31);
            label1.Name = "label1";
            label1.Size = new Size(244, 30);
            label1.TabIndex = 0;
            label1.Text = "Movimiento de Stock";
            // 
            // txtDetalles
            // 
            txtDetalles.Location = new Point(326, 159);
            txtDetalles.Multiline = true;
            txtDetalles.Name = "txtDetalles";
            txtDetalles.Size = new Size(173, 109);
            txtDetalles.TabIndex = 2;
            // 
            // dtpFechaMovimiento
            // 
            dtpFechaMovimiento.Location = new Point(312, 294);
            dtpFechaMovimiento.Name = "dtpFechaMovimiento";
            dtpFechaMovimiento.Size = new Size(200, 23);
            dtpFechaMovimiento.TabIndex = 3;
            // 
            // btnGuardarMovimiento
            // 
            btnGuardarMovimiento.Location = new Point(303, 344);
            btnGuardarMovimiento.Name = "btnGuardarMovimiento";
            btnGuardarMovimiento.Size = new Size(209, 42);
            btnGuardarMovimiento.TabIndex = 4;
            btnGuardarMovimiento.Text = "Retirar";
            btnGuardarMovimiento.UseVisualStyleBackColor = true;
            btnGuardarMovimiento.Click += btnGuardarMovimiento_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 118);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 5;
            label2.Text = "Cantidad a Retirar :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 162);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Detalles : ";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(537, 344);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(81, 42);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // numericCantidad
            // 
            numericCantidad.Location = new Point(349, 110);
            numericCantidad.Name = "numericCantidad";
            numericCantidad.Size = new Size(120, 23);
            numericCantidad.TabIndex = 8;
            // 
            // MovimientoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(numericCantidad);
            Controls.Add(btnVolver);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnGuardarMovimiento);
            Controls.Add(dtpFechaMovimiento);
            Controls.Add(txtDetalles);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MovimientoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movimiento de Stock";
            ((System.ComponentModel.ISupportInitialize)numericCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDetalles;
        private DateTimePicker dtpFechaMovimiento;
        private Button btnGuardarMovimiento;
        private Label label2;
        private Label label3;
        private Button btnVolver;
        private NumericUpDown numericCantidad;
    }
}