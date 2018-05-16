using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using lad.org.business;

namespace lad.org.presentation
{
    public partial class frmRecibido : Form
    {
        string message_suubject;
        string message_author;
        string tagline;
        TextBox user, pass;

        public frmRecibido(TextBox user, TextBox pass)
        {
            InitializeComponent();
            this.user = user;
            this.pass = pass;
            GetFeeds();
            getAllMails();
        }

        private void frmRecibido_Load(object sender, EventArgs e)
        {
          
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void getAllMails() {

            WebClient objClient = new WebClient();

            string response = null;

            XmlDocument xdoc = new XmlDocument();

            try
            {
                objClient.Credentials = new NetworkCredential(user.Text.Split('@')[0].Trim(), pass.Text.Trim());

                response = Encoding.UTF8.GetString(objClient.DownloadData("https://mail.google.com/mail/feed/atom"));

                response = response.Replace("<feed version=\"0.3\" xmlns=\"http://purl.org/atom/ns#\">", "<feed>");

                xdoc.LoadXml(response);

                DataTable dt = new DataTable("inbox");
                dt.Columns.Add("Asunto ", typeof(string));
                dt.Columns.Add("De ", typeof(string));
                dt.Columns.Add("Resumen ", typeof(string));
                dt.Columns.Add("Fecha", typeof(string));
                dataGridView1.DataSource = dt;

                if (Variables.mailcount > 0)
                {
                    Variables.emailfrom = new string[Variables.mailcount - 1];
                    Variables.email_Messages = new string[Variables.mailcount];
                    foreach (XmlNode node1 in xdoc.SelectNodes("feed/entry"))
                    {

                        dt.Rows.Add(node1.SelectSingleNode("title").InnerText,
                            node1.SelectSingleNode("author").SelectSingleNode("name").InnerText,
                            node1.SelectSingleNode("summary").InnerText,
                            node1.SelectSingleNode("issued").InnerText
                            );
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lblx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblg_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblx_MouseHover(object sender, EventArgs e)
        {
            lblx.ForeColor = Color.FromArgb(62, 57, 202);
        }

        private void lblx_MouseLeave(object sender, EventArgs e)
        {
            lblx.ForeColor = Color.White;
        }

        private void lblg_MouseHover(object sender, EventArgs e)
        {
            lblg.ForeColor = Color.FromArgb(62, 57, 202);
        }

        private void lblg_MouseLeave(object sender, EventArgs e)
        {
            lblg.ForeColor = Color.White;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try {
                txtREsumen.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception) { }

             
        }

        public void GetFeeds()
        {
            WebClient objClient = new WebClient();
            XmlNodeList nodelist = default(XmlNodeList);
            XmlNode node = default(XmlNode);
            XmlNode node2 = default(XmlNode);
            string response = null;
            XmlDocument xdoc = new XmlDocument();

            try
            {

                objClient.Credentials = new NetworkCredential("dominicsc2hs".Trim(), "kingdedede2013".Trim());

                response = Encoding.UTF8.GetString(objClient.DownloadData("https://mail.google.com/mail/feed/atom"));

                response = response.Replace("<feed version=\"0.3\" xmlns=\"http://purl.org/atom/ns#\">", "<feed>");

                xdoc.LoadXml(response);

                node = xdoc.SelectSingleNode("/feed/fullcount");

                Variables.mailcount = Convert.ToInt16(node.InnerText);
                tagline = xdoc.SelectSingleNode("/feed/tagline").InnerText;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
