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
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
            LogOut();
            LlenarContainer();
          
        }

        private void LlenarContainer()
        {
            if (!container.Controls.Contains(usercPanel.Instance))
            {
                container.Controls.Add(usercPanel.Instance);
                usercPanel.Instance.Dock = DockStyle.Fill;
                usercPanel.Instance.BringToFront();
            }
            else
                usercPanel.Instance.BringToFront();
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(62, 57, 202);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromArgb(62, 57, 202);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(usercRegistrarOrden.Instance))
            {
                container.Controls.Add(usercRegistrarOrden.Instance);
                usercRegistrarOrden.Instance.Dock = DockStyle.Fill;
                usercRegistrarOrden.Instance.BringToFront();
            }
            else
                usercRegistrarOrden.Instance.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(usercRegistrarOrden.Instance))
            {
                container.Controls.Add(usercRegistrarOrden.Instance);
                usercRegistrarOrden.Instance.Dock = DockStyle.Fill;
                usercRegistrarOrden.Instance.BringToFront();
            }
            else
                usercRegistrarOrden.Instance.BringToFront();
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            
        }

        private void container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void laboratoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(usercAdministrarMarca.Instance))
            {
                container.Controls.Add(usercAdministrarMarca.Instance);
                usercAdministrarMarca.Instance.Dock = DockStyle.Fill;
                usercAdministrarMarca.Instance.BringToFront();
            }
            else
                usercAdministrarMarca.Instance.BringToFront();
        }

        private void picMarca_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(usercAdministrarMarca.Instance))
            {
                container.Controls.Add(usercAdministrarMarca.Instance);
                usercAdministrarMarca.Instance.Dock = DockStyle.Fill;
                usercAdministrarMarca.Instance.BringToFront();
            }
            else
                usercAdministrarMarca.Instance.BringToFront();
        }

        private void picCategoría_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(usercAdministrarCategoria.Instance))
            {
                container.Controls.Add(usercAdministrarCategoria.Instance);
                usercAdministrarCategoria.Instance.Dock = DockStyle.Fill;
                usercAdministrarCategoria.Instance.BringToFront();
            }
            else
                usercAdministrarCategoria.Instance.BringToFront();
        }

        private void btnCategorías_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(usercAdministrarCategoria.Instance))
            {
                container.Controls.Add(usercAdministrarCategoria.Instance);
                usercAdministrarCategoria.Instance.Dock = DockStyle.Fill;
                usercAdministrarCategoria.Instance.BringToFront();
            }
            else
                usercAdministrarCategoria.Instance.BringToFront();
        }

        private void btnPresentaciones_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(usercPresentacion.Instance))
            {
                container.Controls.Add(usercPresentacion.Instance);
                usercPresentacion.Instance.Dock = DockStyle.Fill;
                usercPresentacion.Instance.BringToFront();
            }
            else
                usercPresentacion.Instance.BringToFront();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(usercProducto.Instance))
            {
                container.Controls.Add(usercProducto.Instance);
                usercProducto.Instance.Dock = DockStyle.Fill;
                usercProducto.Instance.BringToFront();
            }
            else
                usercProducto.Instance.BringToFront();
        }

        private void picPresentación_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(usercPresentacion.Instance))
            {
                container.Controls.Add(usercPresentacion.Instance);
                usercPresentacion.Instance.Dock = DockStyle.Fill;
                usercPresentacion.Instance.BringToFront();
            }
            else
                usercPresentacion.Instance.BringToFront();
        }

        private void picProducto_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(usercProducto.Instance))
            {
                container.Controls.Add(usercProducto.Instance);
                usercProducto.Instance.Dock = DockStyle.Fill;
                usercProducto.Instance.BringToFront();
            }
            else
                usercProducto.Instance.BringToFront();
        }

        private void picLaboratorio_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(usercAdministrarLaboratorios.Instance))
            {
                container.Controls.Add(usercAdministrarLaboratorios.Instance);
                usercAdministrarLaboratorios.Instance.Dock = DockStyle.Fill;
                usercAdministrarLaboratorios.Instance.BringToFront();
            }
            else
                usercAdministrarLaboratorios.Instance.BringToFront();
            
        }

        private void btnLaboratorios_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(usercAdministrarLaboratorios.Instance))
            {
                container.Controls.Add(usercAdministrarLaboratorios.Instance);
                usercAdministrarLaboratorios.Instance.Dock = DockStyle.Fill;
                usercAdministrarLaboratorios.Instance.BringToFront();
            }
            else
                usercAdministrarLaboratorios.Instance.BringToFront();
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            container.Controls.Clear();
            usercContacto frm = new usercContacto(lblCorreo);
            container.Controls.Add(frm);
        }

        private void picContacto_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            usercContacto frm = new usercContacto(lblCorreo);
            container.Controls.Add(frm);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (btnLogIn.Text == "LogIn")
            {
                frmLogIn frm = new frmLogIn(picIngreso, picContacto, btnIngresos, bunifuFlatButton2, btnLogIn, container,
                    picCategoría, picLaboratorio, btnCategorías, btnLaboratorios,  picProducto, picPresentación, picMarca,
                    btnProductos, btnPresentaciones, btnMarcas, cardUsuario, lblNombre, lblCorreo, btnUsuario, lblCodigo);
                frm.Show();
            }
            else {
                container.Controls.Clear();
                LlenarContainer();
                LogOut();
                MessageBox.Show("Has cerrado sesión");
            }
          
        }

        private void LogOut()
        {
            cardUsuario.Visible = false;
            btnUsuario.Visible = false;
            btnLogIn.Text = "LogIn";
            btnCategorías.Enabled = false;
            btnCategorías.Cursor = Cursors.Default;
            btnIngresos.Enabled = false;
            btnIngresos.Cursor = Cursors.Default;
            btnLaboratorios.Enabled = false;
            btnLaboratorios.Cursor = Cursors.Default;
            btnMarcas.Enabled = false;
            btnMarcas.Cursor = Cursors.Default;
            btnProductos.Enabled = false;
            btnProductos.Cursor = Cursors.Default;
            btnPresentaciones.Enabled = false;
            btnPresentaciones.Cursor = Cursors.Default;
            bunifuFlatButton2.Enabled = false;
            bunifuFlatButton2.Cursor = Cursors.Default;
            picCategoría.Enabled = false;
            picContacto.Enabled = false;
            picIngreso.Enabled = false;
            picMarca.Enabled = false;
            picProducto.Enabled = false;
            picPresentación.Enabled = false;
            picLaboratorio.Enabled = false;
        }
    }
}
