namespace MgSistemas
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            verInventarioToolStripMenuItem = new ToolStripMenuItem();
            verInventarioToolStripMenuItem1 = new ToolStripMenuItem();
            generarRequerimientoToolStripMenuItem = new ToolStripMenuItem();
            verRQPendientesToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            btnGestionUsuarios = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            verProveedoresToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            desloguearseToolStripMenuItem = new ToolStripMenuItem();
            btnSalir = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AllowDrop = true;
            menuStrip1.BackColor = Color.FromArgb(239, 35, 60);
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            menuStrip1.GripMargin = new Padding(2);
            menuStrip1.Items.AddRange(new ToolStripItem[] { verInventarioToolStripMenuItem, usuariosToolStripMenuItem, proveedoresToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 2);
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(126, 450);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // verInventarioToolStripMenuItem
            // 
            verInventarioToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            verInventarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verInventarioToolStripMenuItem1, generarRequerimientoToolStripMenuItem, verRQPendientesToolStripMenuItem });
            verInventarioToolStripMenuItem.ForeColor = Color.Black;
            verInventarioToolStripMenuItem.ImageTransparentColor = SystemColors.Window;
            verInventarioToolStripMenuItem.Name = "verInventarioToolStripMenuItem";
            verInventarioToolStripMenuItem.Size = new Size(113, 23);
            verInventarioToolStripMenuItem.Text = "Inventario";
            verInventarioToolStripMenuItem.Click += verInventarioToolStripMenuItem_Click;
            // 
            // verInventarioToolStripMenuItem1
            // 
            verInventarioToolStripMenuItem1.BackColor = Color.FromArgb(239, 35, 60);
            verInventarioToolStripMenuItem1.Name = "verInventarioToolStripMenuItem1";
            verInventarioToolStripMenuItem1.Size = new Size(223, 24);
            verInventarioToolStripMenuItem1.Text = "Ver Inventario";
            verInventarioToolStripMenuItem1.Click += verInventarioToolStripMenuItem1_Click;
            // 
            // generarRequerimientoToolStripMenuItem
            // 
            generarRequerimientoToolStripMenuItem.BackColor = Color.FromArgb(239, 35, 60);
            generarRequerimientoToolStripMenuItem.Name = "generarRequerimientoToolStripMenuItem";
            generarRequerimientoToolStripMenuItem.Size = new Size(223, 24);
            generarRequerimientoToolStripMenuItem.Text = "Generar Requerimiento";
            generarRequerimientoToolStripMenuItem.Click += generarRequerimientoToolStripMenuItem_Click;
            // 
            // verRQPendientesToolStripMenuItem
            // 
            verRQPendientesToolStripMenuItem.BackColor = Color.FromArgb(239, 35, 60);
            verRQPendientesToolStripMenuItem.Name = "verRQPendientesToolStripMenuItem";
            verRQPendientesToolStripMenuItem.Size = new Size(223, 24);
            verRQPendientesToolStripMenuItem.Text = "Ver RQ pendientes";
            verRQPendientesToolStripMenuItem.Click += verRQPendientesToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnGestionUsuarios });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(113, 23);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // btnGestionUsuarios
            // 
            btnGestionUsuarios.BackColor = Color.FromArgb(239, 35, 60);
            btnGestionUsuarios.Name = "btnGestionUsuarios";
            btnGestionUsuarios.Size = new Size(209, 24);
            btnGestionUsuarios.Text = "Administrar Usuarios";
            btnGestionUsuarios.Click += administrarUsuariosToolStripMenuItem_Click;
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verProveedoresToolStripMenuItem });
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(113, 23);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            proveedoresToolStripMenuItem.Click += proveedoresToolStripMenuItem_Click;
            // 
            // verProveedoresToolStripMenuItem
            // 
            verProveedoresToolStripMenuItem.Name = "verProveedoresToolStripMenuItem";
            verProveedoresToolStripMenuItem.Size = new Size(180, 24);
            verProveedoresToolStripMenuItem.Text = "Ver Proveedores";
            verProveedoresToolStripMenuItem.Click += verProveedoresToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { desloguearseToolStripMenuItem, btnSalir });
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(113, 23);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // desloguearseToolStripMenuItem
            // 
            desloguearseToolStripMenuItem.BackColor = Color.FromArgb(239, 35, 60);
            desloguearseToolStripMenuItem.Name = "desloguearseToolStripMenuItem";
            desloguearseToolStripMenuItem.Size = new Size(186, 24);
            desloguearseToolStripMenuItem.Text = "Desloguearse";
            desloguearseToolStripMenuItem.Click += desloguearseToolStripMenuItem_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(239, 35, 60);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(186, 24);
            btnSalir.Text = "Cerrar Aplicacion";
            btnSalir.Click += btnSalir_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem verInventarioToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem btnGestionUsuarios;
        private ToolStripMenuItem verInventarioToolStripMenuItem1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem generarRequerimientoToolStripMenuItem;
        private ToolStripMenuItem desloguearseToolStripMenuItem;
        private ToolStripMenuItem btnSalir;
        private ToolStripMenuItem verRQPendientesToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem verProveedoresToolStripMenuItem;
    }
}
