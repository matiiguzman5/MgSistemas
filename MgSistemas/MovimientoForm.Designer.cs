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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            txtDetalles.Location = new Point(16, 22);
            txtDetalles.Multiline = true;
            txtDetalles.Name = "txtDetalles";
            txtDetalles.Size = new Size(660, 129);
            txtDetalles.TabIndex = 2;
            // 
            // dtpFechaMovimiento
            // 
            dtpFechaMovimiento.Location = new Point(441, 46);
            dtpFechaMovimiento.Name = "dtpFechaMovimiento";
            dtpFechaMovimiento.Size = new Size(227, 23);
            dtpFechaMovimiento.TabIndex = 3;
            // 
            // btnGuardarMovimiento
            // 
            btnGuardarMovimiento.Location = new Point(288, 348);
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
            label2.Location = new Point(171, 28);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 5;
            label2.Text = "Cantidad a Retirar :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(480, 28);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 6;
            label3.Text = "Fecha de Movimiento : ";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(542, 348);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(81, 42);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // numericCantidad
            // 
            numericCantidad.Location = new Point(153, 46);
            numericCantidad.Name = "numericCantidad";
            numericCantidad.Size = new Size(156, 23);
            numericCantidad.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numericCantidad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpFechaMovimiento);
            groupBox1.Location = new Point(12, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(759, 255);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDetalles);
            groupBox2.Location = new Point(29, 95);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(693, 154);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalles";
            // 
            // MovimientoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnVolver);
            Controls.Add(btnGuardarMovimiento);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MovimientoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movimiento de Stock";
            ((System.ComponentModel.ISupportInitialize)numericCantidad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}