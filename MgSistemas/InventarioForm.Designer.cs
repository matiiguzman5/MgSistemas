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
            dataGridViewProductos = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panolContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)initialCreateBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addCodigoProducto2BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)newReleaseDbBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(12, 45);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersVisible = false;
            dataGridViewProductos.Size = new Size(937, 365);
            dataGridViewProductos.TabIndex = 0;
            dataGridViewProductos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 16);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(249, 23);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += textBox2_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(267, 15);
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
            InventarioLbl.Location = new Point(373, 8);
            InventarioLbl.Name = "InventarioLbl";
            InventarioLbl.Size = new Size(114, 30);
            InventarioLbl.TabIndex = 3;
            InventarioLbl.Text = "Inventario";
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSize = true;
            btnAgregar.Location = new Point(542, 16);
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
            btnEliminar.Location = new Point(667, 17);
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
            btnEditar.Location = new Point(792, 16);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(119, 25);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar Producto";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += button2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(825, 416);
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
            btnRetirarProducto.Location = new Point(652, 416);
            btnRetirarProducto.Name = "btnRetirarProducto";
            btnRetirarProducto.Size = new Size(126, 23);
            btnRetirarProducto.TabIndex = 8;
            btnRetirarProducto.Text = "Retirar";
            btnRetirarProducto.UseVisualStyleBackColor = true;
            btnRetirarProducto.Click += btnMoviento_Click;
            // 
            // btnVerMovimientos
            // 
            btnVerMovimientos.Location = new Point(36, 416);
            btnVerMovimientos.Name = "btnVerMovimientos";
            btnVerMovimientos.Size = new Size(135, 23);
            btnVerMovimientos.TabIndex = 9;
            btnVerMovimientos.Text = "Ver Movimientos";
            btnVerMovimientos.UseVisualStyleBackColor = true;
            btnVerMovimientos.Click += btnVerMovimientos_Click;
            // 
            // InventarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(961, 450);
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)panolContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)initialCreateBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)addCodigoProducto2BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)newReleaseDbBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProductos;
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
    }
}