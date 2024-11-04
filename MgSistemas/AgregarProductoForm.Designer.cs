namespace MgSistemas
{
    partial class AgregarProductoForm
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
            txtNombreProducto = new TextBox();
            dtpFechaIngreso = new DateTimePicker();
            btnAgregaProd = new Button();
            label5 = new Label();
            btnVolverProd = new Button();
            numericCantProd = new NumericUpDown();
            numericCodeProd = new NumericUpDown();
            txtDescripcion = new TextBox();
            label7 = new Label();
            CategoriaBox = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numericCantProd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCodeProd).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 34);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo de Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 34);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre del Producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(568, 79);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha de Ingreso:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(350, 79);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Cantidad:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(448, 31);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(176, 23);
            txtNombreProducto.TabIndex = 5;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Location = new Point(509, 97);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(214, 23);
            dtpFechaIngreso.TabIndex = 7;
            // 
            // btnAgregaProd
            // 
            btnAgregaProd.Location = new Point(275, 386);
            btnAgregaProd.Name = "btnAgregaProd";
            btnAgregaProd.Size = new Size(126, 54);
            btnAgregaProd.TabIndex = 9;
            btnAgregaProd.Text = "Agregar Producto";
            btnAgregaProd.UseVisualStyleBackColor = true;
            btnAgregaProd.Click += btnAgregaProd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(293, 9);
            label5.Name = "label5";
            label5.Size = new Size(233, 32);
            label5.TabIndex = 10;
            label5.Text = "Agregar Productos";
            // 
            // btnVolverProd
            // 
            btnVolverProd.Location = new Point(425, 388);
            btnVolverProd.Name = "btnVolverProd";
            btnVolverProd.Size = new Size(126, 54);
            btnVolverProd.TabIndex = 11;
            btnVolverProd.Text = "Cancelar";
            btnVolverProd.UseVisualStyleBackColor = true;
            btnVolverProd.Click += btnVolverProd_Click;
            // 
            // numericCantProd
            // 
            numericCantProd.Location = new Point(323, 97);
            numericCantProd.Name = "numericCantProd";
            numericCantProd.Size = new Size(120, 23);
            numericCantProd.TabIndex = 12;
            numericCantProd.ValueChanged += numericCantProd_ValueChanged;
            // 
            // numericCodeProd
            // 
            numericCodeProd.Location = new Point(165, 32);
            numericCodeProd.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericCodeProd.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericCodeProd.Name = "numericCodeProd";
            numericCodeProd.Size = new Size(120, 23);
            numericCodeProd.TabIndex = 13;
            numericCodeProd.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericCodeProd.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(6, 22);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(764, 122);
            txtDescripcion.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(154, 79);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 16;
            label7.Text = "Sector:";
            // 
            // CategoriaBox
            // 
            CategoriaBox.FormattingEnabled = true;
            CategoriaBox.Items.AddRange(new object[] { "Repuestos", "Accesorios", "Administrativo", "Sistemas" });
            CategoriaBox.Location = new Point(116, 97);
            CategoriaBox.Name = "CategoriaBox";
            CategoriaBox.Size = new Size(121, 23);
            CategoriaBox.TabIndex = 17;
            CategoriaBox.SelectedIndexChanged += CategoriaBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CategoriaBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpFechaIngreso);
            groupBox1.Controls.Add(txtNombreProducto);
            groupBox1.Controls.Add(numericCantProd);
            groupBox1.Controls.Add(numericCodeProd);
            groupBox1.Location = new Point(12, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 154);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Producto";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDescripcion);
            groupBox2.Location = new Point(12, 230);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 150);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Descripcion";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // AgregarProductoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnVolverProd);
            Controls.Add(label5);
            Controls.Add(btnAgregaProd);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AgregarProductoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Producto";
            Load += AgregarProductoForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericCantProd).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCodeProd).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombreProducto;
        private DateTimePicker dtpFechaIngreso;
        private Button btnAgregaProd;
        private Label label5;
        private Button btnVolverProd;
        private NumericUpDown numericCantProd;
        private NumericUpDown numericCodeProd;
        private TextBox txtDescripcion;
        private Label label7;
        private ComboBox CategoriaBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}