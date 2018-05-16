namespace lad.org.presentation
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRegistrarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPresentacion = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarLaboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratorioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ordenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarOrdenIngresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeIngresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.laboratorioToolStripMenuItem,
            this.ordenesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1403, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRegistrarProducto});
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.productoToolStripMenuItem.Text = "Productos";
            // 
            // tsmRegistrarProducto
            // 
            this.tsmRegistrarProducto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProducto,
            this.tsmiMarca,
            this.tsmiCategoria,
            this.tsmiPresentacion});
            this.tsmRegistrarProducto.Name = "tsmRegistrarProducto";
            this.tsmRegistrarProducto.Size = new System.Drawing.Size(181, 26);
            this.tsmRegistrarProducto.Text = "Nuevo";
            // 
            // tsmiProducto
            // 
            this.tsmiProducto.Name = "tsmiProducto";
            this.tsmiProducto.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsmiProducto.Size = new System.Drawing.Size(258, 26);
            this.tsmiProducto.Text = "Producto";
            this.tsmiProducto.Click += new System.EventHandler(this.tsmiProducto_Click);
            // 
            // tsmiMarca
            // 
            this.tsmiMarca.Name = "tsmiMarca";
            this.tsmiMarca.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.tsmiMarca.Size = new System.Drawing.Size(258, 26);
            this.tsmiMarca.Text = "Marca";
            this.tsmiMarca.Click += new System.EventHandler(this.tsmiMarca_Click);
            // 
            // tsmiCategoria
            // 
            this.tsmiCategoria.Name = "tsmiCategoria";
            this.tsmiCategoria.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.tsmiCategoria.Size = new System.Drawing.Size(258, 26);
            this.tsmiCategoria.Text = "Categoría";
            this.tsmiCategoria.Click += new System.EventHandler(this.tsmiCategoria_Click);
            // 
            // tsmiPresentacion
            // 
            this.tsmiPresentacion.Name = "tsmiPresentacion";
            this.tsmiPresentacion.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.tsmiPresentacion.Size = new System.Drawing.Size(258, 26);
            this.tsmiPresentacion.Text = "Presentación";
            this.tsmiPresentacion.Click += new System.EventHandler(this.tsmiPresentacion_Click);
            // 
            // laboratorioToolStripMenuItem
            // 
            this.laboratorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarLaboratorioToolStripMenuItem});
            this.laboratorioToolStripMenuItem.Name = "laboratorioToolStripMenuItem";
            this.laboratorioToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.laboratorioToolStripMenuItem.Text = "Laboratorios";
            // 
            // registrarLaboratorioToolStripMenuItem
            // 
            this.registrarLaboratorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laboratorioToolStripMenuItem1});
            this.registrarLaboratorioToolStripMenuItem.Name = "registrarLaboratorioToolStripMenuItem";
            this.registrarLaboratorioToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.registrarLaboratorioToolStripMenuItem.Text = "Nuevo";
            // 
            // laboratorioToolStripMenuItem1
            // 
            this.laboratorioToolStripMenuItem1.Name = "laboratorioToolStripMenuItem1";
            this.laboratorioToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.laboratorioToolStripMenuItem1.Size = new System.Drawing.Size(211, 26);
            this.laboratorioToolStripMenuItem1.Text = "Laboratorio";
            this.laboratorioToolStripMenuItem1.Click += new System.EventHandler(this.laboratorioToolStripMenuItem1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1403, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(52, 24);
            this.toolStripLabel1.Text = "Nuevo";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "Añadir Producto";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "Añadir Laboratorio";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 631);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1403, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 20);
            this.toolStripStatusLabel1.Text = "Farmacia";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // ordenesToolStripMenuItem
            // 
            this.ordenesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarOrdenIngresoToolStripMenuItem});
            this.ordenesToolStripMenuItem.Name = "ordenesToolStripMenuItem";
            this.ordenesToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.ordenesToolStripMenuItem.Text = "Ordenes";
            // 
            // ingresarOrdenIngresoToolStripMenuItem
            // 
            this.ingresarOrdenIngresoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenDeIngresoToolStripMenuItem});
            this.ingresarOrdenIngresoToolStripMenuItem.Name = "ingresarOrdenIngresoToolStripMenuItem";
            this.ingresarOrdenIngresoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.ingresarOrdenIngresoToolStripMenuItem.Text = "Nueva";
            this.ingresarOrdenIngresoToolStripMenuItem.Click += new System.EventHandler(this.ingresarOrdenIngresoToolStripMenuItem_Click);
            // 
            // ordenDeIngresoToolStripMenuItem
            // 
            this.ordenDeIngresoToolStripMenuItem.Name = "ordenDeIngresoToolStripMenuItem";
            this.ordenDeIngresoToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.ordenDeIngresoToolStripMenuItem.Text = "Orden de ingreso";
            this.ordenDeIngresoToolStripMenuItem.Click += new System.EventHandler(this.ordenDeIngresoToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 656);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmRegistrarProducto;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem laboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarLaboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiProducto;
        private System.Windows.Forms.ToolStripMenuItem tsmiMarca;
        private System.Windows.Forms.ToolStripMenuItem tsmiCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsmiPresentacion;
        private System.Windows.Forms.ToolStripMenuItem laboratorioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ordenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarOrdenIngresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenDeIngresoToolStripMenuItem;
    }
}

