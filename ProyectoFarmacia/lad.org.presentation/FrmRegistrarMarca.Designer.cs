namespace lad.org.presentation
{
    partial class FrmRegistrarMarca
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
            this.dgMarcas = new System.Windows.Forms.DataGridView();
            this.Codigo_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarMarca = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMarcas
            // 
            this.dgMarcas.AllowUserToAddRows = false;
            this.dgMarcas.AllowUserToDeleteRows = false;
            this.dgMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Marca,
            this.NombreMarca});
            this.dgMarcas.Location = new System.Drawing.Point(24, 130);
            this.dgMarcas.Name = "dgMarcas";
            this.dgMarcas.ReadOnly = true;
            this.dgMarcas.Size = new System.Drawing.Size(343, 187);
            this.dgMarcas.TabIndex = 0;
            this.dgMarcas.SelectionChanged += new System.EventHandler(this.dgMarcas_SelectionChanged);
            // 
            // Codigo_Marca
            // 
            this.Codigo_Marca.DataPropertyName = "Codigo_Marca";
            this.Codigo_Marca.HeaderText = "Código";
            this.Codigo_Marca.Name = "Codigo_Marca";
            this.Codigo_Marca.ReadOnly = true;
            // 
            // NombreMarca
            // 
            this.NombreMarca.DataPropertyName = "NombreMarca";
            this.NombreMarca.HeaderText = "Nombre";
            this.NombreMarca.Name = "NombreMarca";
            this.NombreMarca.ReadOnly = true;
            this.NombreMarca.Width = 200;
            // 
            // txtNombreMarca
            // 
            this.txtNombreMarca.Location = new System.Drawing.Point(62, 49);
            this.txtNombreMarca.Name = "txtNombreMarca";
            this.txtNombreMarca.Size = new System.Drawing.Size(318, 20);
            this.txtNombreMarca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // btnRegistrarMarca
            // 
            this.btnRegistrarMarca.Location = new System.Drawing.Point(66, 101);
            this.btnRegistrarMarca.Name = "btnRegistrarMarca";
            this.btnRegistrarMarca.Size = new System.Drawing.Size(64, 23);
            this.btnRegistrarMarca.TabIndex = 3;
            this.btnRegistrarMarca.Text = "Registrar";
            this.btnRegistrarMarca.UseVisualStyleBackColor = true;
            this.btnRegistrarMarca.Click += new System.EventHandler(this.btnRegistrarMarca_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Location = new System.Drawing.Point(211, 101);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMarca.TabIndex = 4;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(136, 101);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(69, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(292, 101);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Registrar Marca";
            // 
            // FrmRegistrarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 329);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnRegistrarMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreMarca);
            this.Controls.Add(this.dgMarcas);
            this.Name = "FrmRegistrarMarca";
            this.Text = "FrmRegistrarMarca";
            this.Load += new System.EventHandler(this.FrmRegistrarMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMarcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMarca;
        private System.Windows.Forms.TextBox txtNombreMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label4;
    }
}