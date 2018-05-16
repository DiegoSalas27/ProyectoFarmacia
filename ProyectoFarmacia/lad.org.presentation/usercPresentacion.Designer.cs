namespace lad.org.presentation
{
    partial class usercPresentacion
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            this.dgPresentacion = new System.Windows.Forms.DataGridView();
            this.Codigo_Presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePresentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminarPresentacion = new System.Windows.Forms.Button();
            this.btnRegistrarPresentacion = new System.Windows.Forms.Button();
            this.txtNombrePresentacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.Codigo_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Composicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_por_unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPresentacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label4.Location = new System.Drawing.Point(447, 21);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(200, 21);
            label4.TabIndex = 113;
            label4.Text = "Administrar Categorias";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label2.Location = new System.Drawing.Point(445, 18);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(215, 21);
            label2.TabIndex = 14;
            label2.Text = "Administrar Presentación";
            // 
            // dgPresentacion
            // 
            this.dgPresentacion.AllowUserToAddRows = false;
            this.dgPresentacion.AllowUserToDeleteRows = false;
            this.dgPresentacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPresentacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Presentacion,
            this.NombrePresentacion});
            this.dgPresentacion.Location = new System.Drawing.Point(25, 263);
            this.dgPresentacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgPresentacion.Name = "dgPresentacion";
            this.dgPresentacion.ReadOnly = true;
            this.dgPresentacion.RowTemplate.Height = 24;
            this.dgPresentacion.Size = new System.Drawing.Size(389, 220);
            this.dgPresentacion.TabIndex = 122;
            this.dgPresentacion.SelectionChanged += new System.EventHandler(this.dgPresentacion_SelectionChanged);
            // 
            // Codigo_Presentacion
            // 
            this.Codigo_Presentacion.DataPropertyName = "Codigo_Presentacion";
            this.Codigo_Presentacion.HeaderText = "Codigo";
            this.Codigo_Presentacion.Name = "Codigo_Presentacion";
            this.Codigo_Presentacion.ReadOnly = true;
            // 
            // NombrePresentacion
            // 
            this.NombrePresentacion.DataPropertyName = "NombrePresentacion";
            this.NombrePresentacion.HeaderText = "Nombre";
            this.NombrePresentacion.Name = "NombrePresentacion";
            this.NombrePresentacion.ReadOnly = true;
            this.NombrePresentacion.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(275, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 121;
            this.label1.Text = "Nombre:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(579, 145);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 120;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminarPresentacion
            // 
            this.btnEliminarPresentacion.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPresentacion.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarPresentacion.Location = new System.Drawing.Point(471, 145);
            this.btnEliminarPresentacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarPresentacion.Name = "btnEliminarPresentacion";
            this.btnEliminarPresentacion.Size = new System.Drawing.Size(100, 28);
            this.btnEliminarPresentacion.TabIndex = 118;
            this.btnEliminarPresentacion.Text = "Eliminar";
            this.btnEliminarPresentacion.UseVisualStyleBackColor = true;
            this.btnEliminarPresentacion.Click += new System.EventHandler(this.btnEliminarPresentacion_Click);
            // 
            // btnRegistrarPresentacion
            // 
            this.btnRegistrarPresentacion.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPresentacion.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarPresentacion.Location = new System.Drawing.Point(278, 145);
            this.btnRegistrarPresentacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarPresentacion.Name = "btnRegistrarPresentacion";
            this.btnRegistrarPresentacion.Size = new System.Drawing.Size(85, 28);
            this.btnRegistrarPresentacion.TabIndex = 117;
            this.btnRegistrarPresentacion.Text = "Registrar";
            this.btnRegistrarPresentacion.UseVisualStyleBackColor = true;
            this.btnRegistrarPresentacion.Click += new System.EventHandler(this.btnRegistrarPresentacion_Click);
            // 
            // txtNombrePresentacion
            // 
            this.txtNombrePresentacion.Location = new System.Drawing.Point(371, 101);
            this.txtNombrePresentacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombrePresentacion.Name = "txtNombrePresentacion";
            this.txtNombrePresentacion.Size = new System.Drawing.Size(364, 22);
            this.txtNombrePresentacion.TabIndex = 116;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(21, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 115;
            this.label3.Text = "Presentación";
            // 
            // dgProductos
            // 
            this.dgProductos.AllowUserToAddRows = false;
            this.dgProductos.AllowUserToDeleteRows = false;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Producto,
            this.Nombre_Prod,
            this.Composicion,
            this.Precio,
            this.Stock,
            this.Marca,
            this.Categoria,
            this.Presentacion,
            this.Cantidad_por_unidad});
            this.dgProductos.Location = new System.Drawing.Point(25, 562);
            this.dgProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.ReadOnly = true;
            this.dgProductos.Size = new System.Drawing.Size(1045, 240);
            this.dgProductos.TabIndex = 114;
            // 
            // Codigo_Producto
            // 
            this.Codigo_Producto.DataPropertyName = "Codigo_Producto";
            this.Codigo_Producto.HeaderText = "Código";
            this.Codigo_Producto.Name = "Codigo_Producto";
            this.Codigo_Producto.ReadOnly = true;
            // 
            // Nombre_Prod
            // 
            this.Nombre_Prod.DataPropertyName = "NombreProd";
            this.Nombre_Prod.HeaderText = "Nombre";
            this.Nombre_Prod.Name = "Nombre_Prod";
            this.Nombre_Prod.ReadOnly = true;
            // 
            // Composicion
            // 
            this.Composicion.DataPropertyName = "Composicion";
            this.Composicion.HeaderText = "Composición";
            this.Composicion.Name = "Composicion";
            this.Composicion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Presentacion
            // 
            this.Presentacion.DataPropertyName = "Presentacion";
            this.Presentacion.HeaderText = "Presentacion";
            this.Presentacion.Name = "Presentacion";
            this.Presentacion.ReadOnly = true;
            // 
            // Cantidad_por_unidad
            // 
            this.Cantidad_por_unidad.DataPropertyName = "Cantidad_por_unidad";
            this.Cantidad_por_unidad.HeaderText = "Cantidad_por_unidad";
            this.Cantidad_por_unidad.Name = "Cantidad_por_unidad";
            this.Cantidad_por_unidad.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 57);
            this.panel1.TabIndex = 123;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(371, 145);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(92, 28);
            this.btnEditar.TabIndex = 124;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(21, 515);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 125;
            this.label5.Text = "Productos";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(687, 145);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 28);
            this.btnActualizar.TabIndex = 126;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // usercPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgPresentacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminarPresentacion);
            this.Controls.Add(this.btnRegistrarPresentacion);
            this.Controls.Add(this.txtNombrePresentacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(label4);
            this.Controls.Add(this.dgProductos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "usercPresentacion";
            this.Size = new System.Drawing.Size(1093, 826);
            this.Load += new System.EventHandler(this.usercPresentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPresentacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPresentacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminarPresentacion;
        private System.Windows.Forms.Button btnRegistrarPresentacion;
        private System.Windows.Forms.TextBox txtNombrePresentacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Composicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_por_unidad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Presentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePresentacion;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnActualizar;
    }
}
