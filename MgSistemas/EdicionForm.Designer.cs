namespace MgSistemas
{
    partial class EdicionForm
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
            CategoriaBox = new ComboBox();
            label7 = new Label();
            txtDescripcion = new TextBox();
            numericCodeProd = new NumericUpDown();
            numericCantProd = new NumericUpDown();
            txtNombreProducto = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            btnGuardarCambios = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)numericCodeProd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCantProd).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // CategoriaBox
            // 
            CategoriaBox.FormattingEnabled = true;
            CategoriaBox.Items.AddRange(new object[] { "Repuestos", "Accesorios", "Administrativo", "Sistemas" });
            CategoriaBox.Location = new Point(315, 107);
            CategoriaBox.Name = "CategoriaBox";
            CategoriaBox.Size = new Size(217, 23);
            CategoriaBox.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(396, 90);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 28;
            label7.Text = "Categoria:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(6, 22);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(721, 91);
            txtDescripcion.TabIndex = 26;
            // 
            // numericCodeProd
            // 
            numericCodeProd.Location = new Point(130, 49);
            numericCodeProd.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericCodeProd.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericCodeProd.Name = "numericCodeProd";
            numericCodeProd.Size = new Size(133, 23);
            numericCodeProd.TabIndex = 25;
            numericCodeProd.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericCantProd
            // 
            numericCantProd.Location = new Point(130, 107);
            numericCantProd.Name = "numericCantProd";
            numericCantProd.Size = new Size(133, 23);
            numericCantProd.TabIndex = 24;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(315, 49);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(217, 23);
            txtNombreProducto.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 90);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 21;
            label4.Text = "Cantidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(362, 31);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 19;
            label2.Text = "Nombre del Producto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 31);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 18;
            label1.Text = "Codigo del Producto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(299, 23);
            label5.Name = "label5";
            label5.Size = new Size(250, 32);
            label5.TabIndex = 30;
            label5.Text = "Modificar Productos";
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(231, 388);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(125, 50);
            btnGuardarCambios.TabIndex = 31;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericCodeProd);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombreProducto);
            groupBox1.Controls.Add(CategoriaBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(numericCantProd);
            groupBox1.Location = new Point(126, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(552, 173);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Producto";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDescripcion);
            groupBox2.Location = new Point(40, 260);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(733, 119);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalles:";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(463, 388);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(125, 50);
            btnVolver.TabIndex = 34;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // EdicionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnGuardarCambios);
            Controls.Add(label5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EdicionForm";
            Text = "Editar";
            ((System.ComponentModel.ISupportInitialize)numericCodeProd).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCantProd).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CategoriaBox;
        private Label label7;
        private TextBox txtDescripcion;
        private NumericUpDown numericCodeProd;
        private NumericUpDown numericCantProd;
        private TextBox txtNombreProducto;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label5;
        private Button btnGuardarCambios;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnVolver;
    }
}