namespace lad.org.presentation
{
    partial class frmRecibido
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label4;
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblg = new System.Windows.Forms.Label();
            this.lblx = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtREsumen = new System.Windows.Forms.RichTextBox();
            label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label4.Location = new System.Drawing.Point(338, 21);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(154, 21);
            label4.TabIndex = 14;
            label4.Text = "Correos recibidos";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.lblg);
            this.panel1.Controls.Add(this.lblx);
            this.panel1.Controls.Add(label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 57);
            this.panel1.TabIndex = 111;
            // 
            // lblg
            // 
            this.lblg.AutoSize = true;
            this.lblg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblg.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblg.ForeColor = System.Drawing.Color.White;
            this.lblg.Location = new System.Drawing.Point(737, 4);
            this.lblg.Name = "lblg";
            this.lblg.Size = new System.Drawing.Size(28, 40);
            this.lblg.TabIndex = 114;
            this.lblg.Text = "-";
            this.lblg.Click += new System.EventHandler(this.lblg_Click);
            this.lblg.MouseLeave += new System.EventHandler(this.lblg_MouseLeave);
            this.lblg.MouseHover += new System.EventHandler(this.lblg_MouseHover);
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblx.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblx.ForeColor = System.Drawing.Color.White;
            this.lblx.Location = new System.Drawing.Point(770, 13);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(28, 30);
            this.lblx.TabIndex = 113;
            this.lblx.Text = "X";
            this.lblx.Click += new System.EventHandler(this.lblx_Click);
            this.lblx.MouseLeave += new System.EventHandler(this.lblx_MouseLeave);
            this.lblx.MouseHover += new System.EventHandler(this.lblx_MouseHover);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(734, 312);
            this.dataGridView1.TabIndex = 112;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txtREsumen
            // 
            this.txtREsumen.Location = new System.Drawing.Point(40, 439);
            this.txtREsumen.Name = "txtREsumen";
            this.txtREsumen.Size = new System.Drawing.Size(734, 198);
            this.txtREsumen.TabIndex = 113;
            this.txtREsumen.Text = "";
            // 
            // frmRecibido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 690);
            this.Controls.Add(this.txtREsumen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecibido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRecibido";
            this.Load += new System.EventHandler(this.frmRecibido_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblg;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.RichTextBox txtREsumen;
    }
}