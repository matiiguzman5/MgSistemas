namespace MgSistemas
{
    partial class RequerimientoForm
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
            groupBox1 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            btnCancelar = new Button();
            btnAceptar = new Button();
            groupBox4 = new GroupBox();
            btnEliminar = new Button();
            btnAgregar = new Button();
            label5 = new Label();
            label4 = new Label();
            numericUpDownCant = new NumericUpDown();
            comboBoxSelecProd = new ComboBox();
            groupBox3 = new GroupBox();
            dataGridViewProductos = new DataGridView();
            ColumnaProd = new DataGridViewTextBoxColumn();
            ColumnaCant = new DataGridViewTextBoxColumn();
            label3 = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            rbtnAlta = new RadioButton();
            rbtnNormal = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            comboBoxUsers = new ComboBox();
            btnNuevoRq = new Button();
            btnModificarRq = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCant).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnAceptar);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxUsers);
            groupBox1.Location = new Point(12, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 495);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Requerimiento";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(467, 23);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 11;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(485, 467);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(232, 466);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnEliminar);
            groupBox4.Controls.Add(btnAgregar);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(numericUpDownCant);
            groupBox4.Controls.Add(comboBoxSelecProd);
            groupBox4.Location = new Point(14, 369);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(750, 92);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Producto a Agregar";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(409, 63);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(242, 63);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(179, 28);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 3;
            label5.Text = "Producto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 28);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 2;
            label4.Text = "Cantidad:";
            // 
            // numericUpDownCant
            // 
            numericUpDownCant.Location = new Point(426, 24);
            numericUpDownCant.Name = "numericUpDownCant";
            numericUpDownCant.Size = new Size(120, 23);
            numericUpDownCant.TabIndex = 1;
            // 
            // comboBoxSelecProd
            // 
            comboBoxSelecProd.FormattingEnabled = true;
            comboBoxSelecProd.Location = new Point(244, 24);
            comboBoxSelecProd.Name = "comboBoxSelecProd";
            comboBoxSelecProd.Size = new Size(112, 23);
            comboBoxSelecProd.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewProductos);
            groupBox3.Location = new Point(13, 211);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(757, 156);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Productos";
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Columns.AddRange(new DataGridViewColumn[] { ColumnaProd, ColumnaCant });
            dataGridViewProductos.Location = new Point(11, 21);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.Size = new Size(734, 129);
            dataGridViewProductos.TabIndex = 0;
            // 
            // ColumnaProd
            // 
            ColumnaProd.HeaderText = "Producto";
            ColumnaProd.Name = "ColumnaProd";
            ColumnaProd.Resizable = DataGridViewTriState.True;
            // 
            // ColumnaCant
            // 
            ColumnaCant.HeaderText = "Cantidad";
            ColumnaCant.Name = "ColumnaCant";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 63);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 6;
            label3.Text = "Observaciones";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 81);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(757, 122);
            textBox1.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtnAlta);
            groupBox2.Controls.Add(rbtnNormal);
            groupBox2.Location = new Point(619, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(157, 50);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Prioridad";
            // 
            // rbtnAlta
            // 
            rbtnAlta.AutoSize = true;
            rbtnAlta.Location = new Point(99, 22);
            rbtnAlta.Name = "rbtnAlta";
            rbtnAlta.Size = new Size(46, 19);
            rbtnAlta.TabIndex = 5;
            rbtnAlta.TabStop = true;
            rbtnAlta.Text = "Alta";
            rbtnAlta.UseVisualStyleBackColor = true;
            // 
            // rbtnNormal
            // 
            rbtnNormal.AutoSize = true;
            rbtnNormal.Location = new Point(6, 22);
            rbtnNormal.Name = "rbtnNormal";
            rbtnNormal.Size = new Size(65, 19);
            rbtnNormal.TabIndex = 4;
            rbtnNormal.TabStop = true;
            rbtnNormal.Text = "Normal";
            rbtnNormal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(353, 28);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 3;
            label2.Text = "Nro Requerimiento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 25);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 1;
            label1.Text = "Responsable";
            // 
            // comboBoxUsers
            // 
            comboBoxUsers.FormattingEnabled = true;
            comboBoxUsers.Location = new Point(86, 22);
            comboBoxUsers.Name = "comboBoxUsers";
            comboBoxUsers.Size = new Size(221, 23);
            comboBoxUsers.TabIndex = 0;
            // 
            // btnNuevoRq
            // 
            btnNuevoRq.Location = new Point(12, 7);
            btnNuevoRq.Name = "btnNuevoRq";
            btnNuevoRq.Size = new Size(92, 23);
            btnNuevoRq.TabIndex = 1;
            btnNuevoRq.Text = "Nuevo";
            btnNuevoRq.UseVisualStyleBackColor = true;
            // 
            // btnModificarRq
            // 
            btnModificarRq.Location = new Point(121, 7);
            btnModificarRq.Name = "btnModificarRq";
            btnModificarRq.Size = new Size(83, 23);
            btnModificarRq.TabIndex = 2;
            btnModificarRq.Text = "Modificar";
            btnModificarRq.UseVisualStyleBackColor = true;
            // 
            // RequerimientoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 543);
            Controls.Add(btnModificarRq);
            Controls.Add(btnNuevoRq);
            Controls.Add(groupBox1);
            Name = "RequerimientoForm";
            Text = "RequerimientoForm";
            Load += RequerimientoForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCant).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxUsers;
        private Button btnNuevoRq;
        private GroupBox groupBox3;
        private Label label3;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private Label label4;
        private NumericUpDown numericUpDownCant;
        private ComboBox comboBoxSelecProd;
        private Label label5;
        private RadioButton rbtnAlta;
        private RadioButton rbtnNormal;
        private Button btnCancelar;
        private Button btnAceptar;
        private Button btnEliminar;
        private Button btnAgregar;
        private Button btnModificarRq;
        private DataGridView dataGridViewProductos;
        private NumericUpDown numericUpDown1;
        private DataGridViewTextBoxColumn ColumnaProd;
        private DataGridViewTextBoxColumn ColumnaCant;
    }
}