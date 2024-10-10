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
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panolContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)initialCreateBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addCodigoProducto2BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)newReleaseDbBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(12, 45);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.Size = new Size(776, 365);
            dataGridViewProductos.TabIndex = 0;
            dataGridViewProductos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 16);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(188, 23);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += textBox2_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(206, 16);
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
            InventarioLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InventarioLbl.Location = new Point(297, 9);
            InventarioLbl.Name = "InventarioLbl";
            InventarioLbl.Size = new Size(89, 21);
            InventarioLbl.TabIndex = 3;
            InventarioLbl.Text = "Inventario";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(419, 15);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(119, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar Producto";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(544, 16);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(669, 15);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(119, 23);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar Producto";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += button2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(669, 416);
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
            // InventarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(InventarioLbl);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(dataGridViewProductos);
            Name = "InventarioForm";
            Text = "InventarioForm";
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
    }
}