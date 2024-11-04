namespace MgSistemas
{
    partial class InventarioForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            InventarioLbl = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            button2 = new Button();
            panolContextBindingSource = new BindingSource(components);
            initialCreateBindingSource = new BindingSource(components);
            addCodigoProducto2BindingSource = new BindingSource(components);
            newReleaseDbBindingSource = new BindingSource(components);
            btnRetirarProducto = new Button();
            btnVerMovimientos = new Button();
            dataGridViewProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)panolContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)initialCreateBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addCodigoProducto2BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)newReleaseDbBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 8);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar :";
            txtBuscar.Size = new Size(249, 23);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += textBox2_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(267, 7);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(59, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // InventarioLbl
            // 
            InventarioLbl.AutoSize = true;
            InventarioLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InventarioLbl.Location = new Point(403, 1);
            InventarioLbl.Name = "InventarioLbl";
            InventarioLbl.Size = new Size(114, 30);
            InventarioLbl.TabIndex = 3;
            InventarioLbl.Text = "Inventario";
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSize = true;
            btnAgregar.Location = new Point(592, 8);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(119, 25);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar Producto";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSize = true;
            btnEliminar.Location = new Point(805, 8);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 25);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.AutoSize = true;
            btnEditar.Location = new Point(1028, 8);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(119, 25);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar Producto";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += button2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1164, 610);
            button2.Name = "button2";
            button2.Size = new Size(119, 23);
            button2.TabIndex = 7;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnVolverMainInv_Click;
            // 
            // panolContextBindingSource
            // 
            panolContextBindingSource.DataSource = typeof(PanolContext);
            // 
            // initialCreateBindingSource
            // 
            initialCreateBindingSource.DataSource = typeof(Migrations.InitialCreate);
            // 
            // addCodigoProducto2BindingSource
            // 
            addCodigoProducto2BindingSource.DataSource = typeof(Migrations.AddCodigoProducto2);
            // 
            // newReleaseDbBindingSource
            // 
            newReleaseDbBindingSource.DataSource = typeof(Migrations.newReleaseDb);
            // 
            // btnRetirarProducto
            // 
            btnRetirarProducto.Font = new Font("Segoe UI", 14F);
            btnRetirarProducto.Location = new Point(592, 605);
            btnRetirarProducto.Name = "btnRetirarProducto";
            btnRetirarProducto.Size = new Size(158, 33);
            btnRetirarProducto.TabIndex = 8;
            btnRetirarProducto.Text = "Retirar";
            btnRetirarProducto.UseVisualStyleBackColor = true;
            btnRetirarProducto.Click += btnMoviento_Click;
            // 
            // btnVerMovimientos
            // 
            btnVerMovimientos.Location = new Point(25, 610);
            btnVerMovimientos.Name = "btnVerMovimientos";
            btnVerMovimientos.Size = new Size(135, 23);
            btnVerMovimientos.TabIndex = 9;
            btnVerMovimientos.Text = "Ver Movimientos";
            btnVerMovimientos.UseVisualStyleBackColor = true;
            btnVerMovimientos.Click += btnVerMovimientos_Click;
            // 
            // dataGridViewProductos
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.EnableHeadersVisualStyles = false;
            dataGridViewProductos.Location = new Point(12, 45);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersVisible = false;
            dataGridViewProductos.RowTemplate.Height = 50;
            dataGridViewProductos.Size = new Size(1281, 554);
            dataGridViewProductos.TabIndex = 0;
            dataGridViewProductos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // InventarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1305, 645);
            Controls.Add(btnVerMovimientos);
            Controls.Add(btnRetirarProducto);
            Controls.Add(button2);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(InventarioLbl);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(dataGridViewProductos);
            Name = "InventarioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventario";
            Load += InventarioForm_Load;
            ((System.ComponentModel.ISupportInitialize)panolContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)initialCreateBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)addCodigoProducto2BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)newReleaseDbBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Label InventarioLbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button button2;
        private BindingSource panolContextBindingSource;
        private BindingSource initialCreateBindingSource;
        private BindingSource newReleaseDbBindingSource;
        private BindingSource addCodigoProducto2BindingSource;
        private Button btnRetirarProducto;
        private Button btnVerMovimientos;
        private DataGridView dataGridViewProductos;
        private Label label2;
        private Label label1;
        private TextBox textBoxCodeProd;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
    }
}