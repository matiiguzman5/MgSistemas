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
            label6 = new Label();
            txtDescripcion = new TextBox();
            numericCodeProd = new NumericUpDown();
            numericCantProd = new NumericUpDown();
            txtNombreProducto = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            btnGuardarCambios = new Button();
            ((System.ComponentModel.ISupportInitialize)numericCodeProd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCantProd).BeginInit();
            SuspendLayout();
            // 
            // CategoriaBox
            // 
            CategoriaBox.FormattingEnabled = true;
            CategoriaBox.Items.AddRange(new object[] { "Repuestos", "Accesorios", "Administrativo", "Sistemas" });
            CategoriaBox.Location = new Point(504, 238);
            CategoriaBox.Name = "CategoriaBox";
            CategoriaBox.Size = new Size(121, 23);
            CategoriaBox.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(405, 241);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 28;
            label7.Text = "Categoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(405, 162);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 27;
            label6.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(497, 137);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(251, 63);
            txtDescripcion.TabIndex = 26;
            // 
            // numericCodeProd
            // 
            numericCodeProd.Location = new Point(178, 140);
            numericCodeProd.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericCodeProd.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericCodeProd.Name = "numericCodeProd";
            numericCodeProd.Size = new Size(120, 23);
            numericCodeProd.TabIndex = 25;
            numericCodeProd.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericCantProd
            // 
            numericCantProd.Location = new Point(194, 233);
            numericCantProd.Name = "numericCantProd";
            numericCantProd.Size = new Size(120, 23);
            numericCantProd.TabIndex = 24;
           
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(178, 184);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(100, 23);
            txtNombreProducto.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 241);
            label4.Name = "label4";
            label4.Size = new Size(137, 15);
            label4.TabIndex = 21;
            label4.Text = "Cantidad que Ingresaron";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 187);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 19;
            label2.Text = "Nombre del Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 142);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 18;
            label1.Text = "Codigo de Producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(272, 46);
            label5.Name = "label5";
            label5.Size = new Size(250, 32);
            label5.TabIndex = 30;
            label5.Text = "Modificar Productos";
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(319, 331);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(125, 63);
            btnGuardarCambios.TabIndex = 31;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // EdicionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardarCambios);
            Controls.Add(label5);
            Controls.Add(CategoriaBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtDescripcion);
            Controls.Add(numericCodeProd);
            Controls.Add(numericCantProd);
            Controls.Add(txtNombreProducto);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EdicionForm";
            Text = "EdicionForm";
            ((System.ComponentModel.ISupportInitialize)numericCodeProd).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCantProd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CategoriaBox;
        private Label label7;
        private Label label6;
        private TextBox txtDescripcion;
        private NumericUpDown numericCodeProd;
        private NumericUpDown numericCantProd;
        private TextBox txtNombreProducto;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label5;
        private Button btnGuardarCambios;
    }
}