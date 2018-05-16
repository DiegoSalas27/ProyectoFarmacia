using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Web;
using System.Net.Mail;
using lad.org.business;
using lad.org.entities2;

namespace lad.org.presentation
{
    public partial class usercContacto : UserControl
    {
        private ILaboratorioService lservice = null;
        private Laboratorio l = null;
        private IUsuarioService uService = null;
        Label lblCorreo;


        public usercContacto(Label lblCorreo)
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            lservice = new LaboratorioService();
            uService = new UsuarioService();
            this.lblCorreo = lblCorreo;
            txtFrom.Text = uService.ObtenerUsarioPorCorreo(lblCorreo.Text).correo;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                l = lservice.ReadByNombreLaboratorio(cbProveedor.Text);

                MailMessage mail = new MailMessage(txtFrom.Text, l.Email, txtSubject.Text, rtbEmail.Text);
                //smtpServer = smtp.company.com; ex: gmail = smtp.gmail.com | yahoo = smtp.yahoo.com
                SmtpClient client = new SmtpClient(txtSmtp.Text);

                // Port 587 is the preferred port for mail submission. Port 25 is widely abused by malware
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential(txtFrom.Text, txtPassword.Text);
                client.EnableSsl = true;
                client.Send(mail);
                MessageBox.Show("Correo enviado", "Exito", MessageBoxButtons.OK);
            }
            catch (Exception) {
                MessageBox.Show("Error al enviar mail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }



        private void FillComboLaboratorio()
        {
            var lista = lservice.Reader();

            lista.ForEach(x =>
            {
                this.cbProveedor.Items.Add(x.Nombre);
            });

        }

        private void usercContacto_Load(object sender, EventArgs e)
        {
            FillComboLaboratorio();
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            l = lservice.ReadByNombreLaboratorio(cbProveedor.Text);
            lblCorreoProv.Text = l.Email;
        }

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {
            if (txtFrom.Text.Contains("gmail")) txtSmtp.Text = "smtp.gmail.com";
            if (txtFrom.Text.Contains("yahoo")) txtSmtp.Text = "smtp.mail.yahoo.com";
            if (txtFrom.Text.Contains("hotmail")) txtSmtp.Text = "smtp.live.com";
        }

        private void btnRecibido_Click(object sender, EventArgs e)
        {
            if (txtFrom.Text != "" && txtPassword.Text != "")
            {
                frmRecibido frm = new frmRecibido(txtFrom, txtPassword);
                frm.Show();
            }
            else {
                MessageBox.Show("Ingrese nombre de usuario y contraseña");
            }  
        }
    }
}
