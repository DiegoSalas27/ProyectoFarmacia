using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lad.org.presentation
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmRegistrarOrden frmProducto = new FrmRegistrarOrden();
            frmProducto.MdiParent = this;
            frmProducto.StartPosition = FormStartPosition.CenterScreen;
            frmProducto.Show();
        }

        private void tsmiProducto_Click(object sender, EventArgs e)
        {
            FrmRegistrarOrden frmProducto = new FrmRegistrarOrden();
            frmProducto.MdiParent = this;
            frmProducto.StartPosition = FormStartPosition.CenterScreen;
            frmProducto.Show();
        }

        private void tsmiMarca_Click(object sender, EventArgs e)
        {
            FrmRegistrarMarca frmMarca = new FrmRegistrarMarca();
            frmMarca.MdiParent = this;
            frmMarca.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void tsmiCategoria_Click(object sender, EventArgs e)
        {

        }

        private void tsmiPresentacion_Click(object sender, EventArgs e)
        {

        }

        private void laboratorioToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ingresarOrdenIngresoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ordenDeIngresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarOrden frmOrden = new FrmRegistrarOrden();
            frmOrden.MdiParent = this;
            frmOrden.Show();
        }
    }
}
