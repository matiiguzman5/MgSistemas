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
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            btnGestionUsuarios = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            desloguearseToolStripMenuItem = new ToolStripMenuItem();
            btnSalir = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { verInventarioToolStripMenuItem, usuariosToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // verInventarioToolStripMenuItem
            // 
            verInventarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verInventarioToolStripMenuItem1, generarRequerimientoToolStripMenuItem });
            verInventarioToolStripMenuItem.Name = "verInventarioToolStripMenuItem";
            verInventarioToolStripMenuItem.Size = new Size(72, 20);
            verInventarioToolStripMenuItem.Text = "Inventario";
            verInventarioToolStripMenuItem.Click += verInventarioToolStripMenuItem_Click;
            // 
            // verInventarioToolStripMenuItem1
            // 
            verInventarioToolStripMenuItem1.Name = "verInventarioToolStripMenuItem1";
            verInventarioToolStripMenuItem1.Size = new Size(196, 22);
            verInventarioToolStripMenuItem1.Text = "Ver Inventario";
            verInventarioToolStripMenuItem1.Click += verInventarioToolStripMenuItem1_Click;
            // 
            // generarRequerimientoToolStripMenuItem
            // 
            generarRequerimientoToolStripMenuItem.Name = "generarRequerimientoToolStripMenuItem";
            generarRequerimientoToolStripMenuItem.Size = new Size(196, 22);
            generarRequerimientoToolStripMenuItem.Text = "Generar Requerimiento";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnGestionUsuarios });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(64, 20);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // btnGestionUsuarios
            // 
            btnGestionUsuarios.Name = "btnGestionUsuarios";
            btnGestionUsuarios.Size = new Size(184, 22);
            btnGestionUsuarios.Text = "Administrar Usuarios";
            btnGestionUsuarios.Click += administrarUsuariosToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { desloguearseToolStripMenuItem, btnSalir });
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // desloguearseToolStripMenuItem
            // 
            desloguearseToolStripMenuItem.Name = "desloguearseToolStripMenuItem";
            desloguearseToolStripMenuItem.Size = new Size(180, 22);
            desloguearseToolStripMenuItem.Text = "Desloguearse";
            desloguearseToolStripMenuItem.Click += desloguearseToolStripMenuItem_Click;
            // 
            // btnSalir
            // 
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(180, 22);
            btnSalir.Text = "Cerrar Aplicacion";
            btnSalir.Click += btnSalir_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
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
    }
}
