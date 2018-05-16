using lad.org.business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lad.org.presentation
{
    public partial class frmLogIn : Form
    {
        IUsuarioService uService;

        PictureBox a, b, h, i, l, m, n;
        Bunifu.Framework.UI.BunifuFlatButton c, d, f, j, k, o, p, q, usuario;
        Panel g;
        Bunifu.Framework.UI.BunifuCards cardUsuario;
        Label lblNombre, lblCorreo, lblCodigo;

        public frmLogIn(PictureBox a, PictureBox b, Bunifu.Framework.UI.BunifuFlatButton c, Bunifu.Framework.UI.BunifuFlatButton d,
            Bunifu.Framework.UI.BunifuFlatButton f, Panel g, PictureBox h, PictureBox i, Bunifu.Framework.UI.BunifuFlatButton j,
            Bunifu.Framework.UI.BunifuFlatButton k, PictureBox l, PictureBox m, PictureBox n,
            Bunifu.Framework.UI.BunifuFlatButton o, Bunifu.Framework.UI.BunifuFlatButton p, Bunifu.Framework.UI.BunifuFlatButton q,
            Bunifu.Framework.UI.BunifuCards cardUsuario, Label lblNombre, Label lblCorreo, Bunifu.Framework.UI.BunifuFlatButton btnusuario,
            Label lblCodigo)
        {
            InitializeComponent();
            uService = new UsuarioService();
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.f = f;
            this.g = g;
            this.h = h;
            this.i = i;
            this.j = j;
            this.k = k;
            this.l = l;
            this.m = m;
            this.n = n;
            this.o = o;
            this.p = p;
            this.q = q;
            this.usuario = btnusuario;
            this.lblNombre = lblNombre;
            this.lblCorreo = lblCorreo;
            this.lblCodigo = lblCodigo;
            this.cardUsuario = cardUsuario;
            txtContrasena.PasswordChar = '*';
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DOMINIC-PC\\SQLEXPRESS;Initial Catalog=dbFarmacia;Integrated Security=True");
            cn.Open();

            SqlCommand cmd = new SqlCommand("select * from usuario where nombre = '" + txtNombreUsuario.Text + "'" +
                " and password = '" + txtContrasena.Text + "'", cn);

            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            int count = 0;
            while (dr.Read())
            {
                count += 1;
            }
            if (count == 1 && uService.ObtenerUsarioPorClave(txtContrasena.Text).roll == "almacenero")
            {
                MessageBox.Show("Bienvenido " + txtNombreUsuario.Text);
                a.Enabled = true;
                b.Enabled = true;
                c.Enabled = true;
                c.Cursor = Cursors.Hand;
                d.Enabled = true;
                d.Cursor = Cursors.Hand;
                f.Text = "Logout";
                cardUsuario.Visible = true;
                usuario.Visible = true;
                usuario.Text = "almacenero";
                llenarLabels();
                g.Controls.Clear();
                if (!g.Controls.Contains(usercPanel.Instance))
                {
                    g.Controls.Add(usercPanel.Instance);
                    usercPanel.Instance.Dock = DockStyle.Fill;
                    usercPanel.Instance.BringToFront();
                }
                else
                    usercPanel.Instance.BringToFront();
                this.Close();
            }
            else if (count == 1 && uService.ObtenerUsarioPorClave(txtContrasena.Text).roll == "administrador")
            {
                MessageBox.Show("Bienvenido " + txtNombreUsuario.Text);
                a.Enabled = true;
                b.Enabled = true;
                c.Enabled = true;
                c.Cursor = Cursors.Hand;
                d.Enabled = true;
                d.Cursor = Cursors.Hand;
                h.Enabled = true;
                i.Enabled = true;
                j.Enabled = true;
                j.Cursor = Cursors.Hand;
                k.Enabled = true;
                k.Cursor = Cursors.Hand;
                l.Enabled = true;
                m.Enabled = true;
                n.Enabled = true;
                o.Enabled = true;
                o.Cursor = Cursors.Hand;
                p.Enabled = true;
                p.Cursor = Cursors.Hand;
                q.Enabled = true;
                q.Cursor = Cursors.Hand;
                f.Text = "Logout";
                cardUsuario.Visible = true;
                usuario.Visible = true;
                usuario.Text = "administrador";
                llenarLabels();
                g.Controls.Clear();
                if (!g.Controls.Contains(usercPanel.Instance))
                {
                    g.Controls.Add(usercPanel.Instance);
                    usercPanel.Instance.Dock = DockStyle.Fill;
                    usercPanel.Instance.BringToFront();
                }
                else
                    usercPanel.Instance.BringToFront();
                this.Close();
            }
            else if (count == 0)
            {
                MessageBox.Show("el nombre de usuario o contraseña no existen");
            }
            txtContrasena.Clear();
            txtNombreUsuario.Clear();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }
        private void llenarLabels()
        {
            lblNombre.Text = uService.ObtenerUsarioPorClave(txtContrasena.Text).nombre;
            lblCorreo.Text = uService.ObtenerUsarioPorClave(txtContrasena.Text).correo;
            lblCodigo.Text = uService.ObtenerUsarioPorClave(txtContrasena.Text).codigo_usuario.ToString();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
