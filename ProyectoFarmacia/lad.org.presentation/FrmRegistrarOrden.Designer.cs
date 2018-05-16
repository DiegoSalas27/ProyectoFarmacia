namespace lad.org.presentation
{
    partial class FrmRegistrarOrden
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblComposicion = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtFechaVenc = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.lblCodProd = new System.Windows.Forms.Label();
            this.lblPrecioUni = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCantUni = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgIngresos = new System.Windows.Forms.DataGridView();
            this.Codigo_Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.cbxComprobante = new System.Windows.Forms.ComboBox();
            this.cbComprobante = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del producto:";
            // 
            // lblComposicion
            // 
            this.lblComposicion.AutoSize = true;
            this.lblComposicion.Location = new System.Drawing.Point(95, 129);
            this.lblComposicion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComposicion.Name = "lblComposicion";
            this.lblComposicion.Size = new System.Drawing.Size(92, 17);
            this.lblComposicion.TabIndex = 2;
            this.lblComposicion.Text = "Composición:";
            // 
            // dtFechaVenc
            // 
            this.dtFechaVenc.Location = new System.Drawing.Point(809, 253);
            this.dtFechaVenc.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaVenc.Name = "dtFechaVenc";
            this.dtFechaVenc.Size = new System.Drawing.Size(157, 22);
            this.dtFechaVenc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de vencimiento:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(95, 161);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(51, 17);
            this.lblMarca.TabIndex = 9;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(95, 193);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(73, 17);
            this.lblCategoria.TabIndex = 11;
            this.lblCategoria.Text = "Categoría:";
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
            this.dgProductos.Location = new System.Drawing.Point(13, 437);
            this.dgProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.ReadOnly = true;
            this.dgProductos.Size = new System.Drawing.Size(1045, 175);
            this.dgProductos.TabIndex = 13;
            this.dgProductos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgProductos_MouseClick);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(404, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Registrar Orden de ingreso";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(481, 326);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 28);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(609, 325);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 28);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(737, 326);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Location = new System.Drawing.Point(95, 225);
            this.lblPresentacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(95, 17);
            this.lblPresentacion.TabIndex = 19;
            this.lblPresentacion.Text = "Presentación:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(866, 325);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cbxProducto
            // 
            this.cbxProducto.Location = new System.Drawing.Point(0, 0);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(121, 24);
            this.cbxProducto.TabIndex = 39;
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Location = new System.Drawing.Point(646, 129);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(136, 17);
            this.lblCodProd.TabIndex = 27;
            this.lblCodProd.Text = "Código de producto:";
            // 
            // lblPrecioUni
            // 
            this.lblPrecioUni.AutoSize = true;
            this.lblPrecioUni.Location = new System.Drawing.Point(646, 161);
            this.lblPrecioUni.Name = "lblPrecioUni";
            this.lblPrecioUni.Size = new System.Drawing.Size(103, 17);
            this.lblPrecioUni.TabIndex = 28;
            this.lblPrecioUni.Text = "Precio unitario:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(646, 193);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(47, 17);
            this.lblStock.TabIndex = 29;
            this.lblStock.Text = "Stock:";
            // 
            // lblCantUni
            // 
            this.lblCantUni.AutoSize = true;
            this.lblCantUni.Location = new System.Drawing.Point(646, 225);
            this.lblCantUni.Name = "lblCantUni";
            this.lblCantUni.Size = new System.Drawing.Size(163, 17);
            this.lblCantUni.TabIndex = 30;
            this.lblCantUni.Text = "Cantidad por unidad(gr):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 258);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Fecha de ingreso:";
            // 
            // dtFechaIngreso
            // 
            this.dtFechaIngreso.Location = new System.Drawing.Point(258, 253);
            this.dtFechaIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaIngreso.Name = "dtFechaIngreso";
            this.dtFechaIngreso.Size = new System.Drawing.Size(157, 22);
            this.dtFechaIngreso.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(95, 294);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Cantidad:";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(258, 288);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 22);
            this.nudCantidad.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(95, 329);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Tipo de comprobante:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 74);
            this.panel1.TabIndex = 37;
            // 
            // dgIngresos
            // 
            this.dgIngresos.AllowUserToAddRows = false;
            this.dgIngresos.AllowUserToDeleteRows = false;
            this.dgIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIngresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Ingreso,
            this.Código_Producto,
            this.Fecha_Ingreso,
            this.Tipo_comprobante,
            this.Cantidad,
            this.Fecha_vencimiento,
            this.Total});
            this.dgIngresos.Location = new System.Drawing.Point(13, 679);
            this.dgIngresos.Margin = new System.Windows.Forms.Padding(4);
            this.dgIngresos.Name = "dgIngresos";
            this.dgIngresos.ReadOnly = true;
            this.dgIngresos.Size = new System.Drawing.Size(1045, 197);
            this.dgIngresos.TabIndex = 38;
            // 
            // Codigo_Ingreso
            // 
            this.Codigo_Ingreso.DataPropertyName = "Codigo_Ingreso";
            this.Codigo_Ingreso.HeaderText = "Código Ingreso";
            this.Codigo_Ingreso.Name = "Codigo_Ingreso";
            this.Codigo_Ingreso.ReadOnly = true;
            this.Codigo_Ingreso.Width = 150;
            // 
            // Código_Producto
            // 
            this.Código_Producto.DataPropertyName = "Código_Producto";
            this.Código_Producto.HeaderText = "Código Producto";
            this.Código_Producto.Name = "Código_Producto";
            this.Código_Producto.ReadOnly = true;
            this.Código_Producto.Width = 150;
            // 
            // Fecha_Ingreso
            // 
            this.Fecha_Ingreso.DataPropertyName = "Fecha_Ingreso";
            this.Fecha_Ingreso.HeaderText = "Fecha ingreso";
            this.Fecha_Ingreso.Name = "Fecha_Ingreso";
            this.Fecha_Ingreso.ReadOnly = true;
            this.Fecha_Ingreso.Width = 150;
            // 
            // Tipo_comprobante
            // 
            this.Tipo_comprobante.DataPropertyName = "Tipo_comprobante";
            this.Tipo_comprobante.HeaderText = "Tipo comprobante";
            this.Tipo_comprobante.Name = "Tipo_comprobante";
            this.Tipo_comprobante.ReadOnly = true;
            this.Tipo_comprobante.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 150;
            // 
            // Fecha_vencimiento
            // 
            this.Fecha_vencimiento.DataPropertyName = "Fecha_vencimiento";
            this.Fecha_vencimiento.HeaderText = "Fecha vencimiento";
            this.Fecha_vencimiento.Name = "Fecha_vencimiento";
            this.Fecha_vencimiento.ReadOnly = true;
            this.Fecha_vencimiento.Width = 150;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 150;
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(258, 94);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(157, 24);
            this.cbProducto.TabIndex = 40;
            this.cbProducto.SelectedIndexChanged += new System.EventHandler(this.cbProducto_SelectedIndexChanged);
            // 
            // cbxComprobante
            // 
            this.cbxComprobante.Location = new System.Drawing.Point(0, 0);
            this.cbxComprobante.Name = "cbxComprobante";
            this.cbxComprobante.Size = new System.Drawing.Size(121, 24);
            this.cbxComprobante.TabIndex = 41;
            // 
            // cbComprobante
            // 
            this.cbComprobante.FormattingEnabled = true;
            this.cbComprobante.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.cbComprobante.Location = new System.Drawing.Point(258, 329);
            this.cbComprobante.Name = "cbComprobante";
            this.cbComprobante.Size = new System.Drawing.Size(157, 24);
            this.cbComprobante.TabIndex = 42;
            this.cbComprobante.SelectedIndexChanged += new System.EventHandler(this.cbComprobante_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(16, 403);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Productos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(13, 635);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "Ordenes de ingreso";
            // 
            // FrmRegistrarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1076, 889);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbComprobante);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.dgIngresos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbxComprobante);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtFechaIngreso);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCantUni);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrecioUni);
            this.Controls.Add(this.lblCodProd);
            this.Controls.Add(this.cbxProducto);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblPresentacion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFechaVenc);
            this.Controls.Add(this.lblComposicion);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRegistrarOrden";
            this.Text = "Registrar orden de ingreso";
            this.Load += new System.EventHandler(this.FrmRegistrarOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIngresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblComposicion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dtFechaVenc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.Label lblCodProd;
        private System.Windows.Forms.Label lblPrecioUni;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblCantUni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Composicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_por_unidad;
        private System.Windows.Forms.DateTimePicker dtFechaIngreso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgIngresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.ComboBox cbxComprobante;
        private System.Windows.Forms.ComboBox cbComprobante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}