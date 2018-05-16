using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lad.org.business;
using lad.org.entities2;

namespace lad.org.presentation
{
    public partial class usercAdministrarLaboratorios : UserControl
    {
        private ILaboratorioService lservice = null;
        private IProductoService pservice = null;
        private Laboratorio l = null;
        int idLaboratorio;

        private static usercAdministrarLaboratorios _instance;

        public static usercAdministrarLaboratorios Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usercAdministrarLaboratorios();
                return _instance;
            }
        }

        public usercAdministrarLaboratorios()
        {
            InitializeComponent();
            dgProductos.AutoGenerateColumns = false;
            dgLaboratorios.AutoGenerateColumns = false;
            lservice = new LaboratorioService();
            pservice = new ProductoService();
        }

        private void FillDataGridView()
        {
            dgLaboratorios.DataSource = lservice.Reader();
            dgProductos.DataSource = pservice.Reader();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            CreateLaboratorio();
            FillDataGridView();
        }

        private void CreateLaboratorio()
        {
            l = null;

                if (txtNombre.Text != "" && txtDireccion.Text != "" && txtEmail.Text != ""
                    && cbEstado.Text != "" && txtTelefono.Text != "")
                {
                    var l = new Laboratorio();

                    l.Nombre = txtNombre.Text;
                    l.Telefono = Convert.ToInt32(txtTelefono.Text);
                    l.Direccion = txtDireccion.Text;
                    l.Email = txtEmail.Text;
                    if (cbEstado.Text == "1" || cbEstado.Text == "True")
                        l.Estado = true;
                    else
                        l.Estado = false;

                    if (lservice.ReadByDireccion(l.Direccion, l.Telefono, l.Email, l.Nombre))
                    {
                        MessageBox.Show("La dirección, teléfono, email o Nombre del laboratorio ingresado ya existe", "Error");
                        return;
                    }
                    else {
                        lservice.Create(l);
                        MessageBox.Show("El laboratorio ha sido registrado");
                        ClearFields(); }
                   
                }
            else
                {
                    MessageBox.Show(this, "Complete los campos requeridos", "Error al editar",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ClearFields();
        }

        private void ClearFields()
        {
            l = null;

            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            cbEstado.Text = "";
            txtTelefono.Text = "";
        }

        private void usercAdministrarLaboratorios_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.ClearFields();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            UpdateLaboratorio();
            FillDataGridView();
        }

        private void UpdateLaboratorio()
        {
            if (dgLaboratorios.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Seleccione el laboratorio que desea editar", "Error al editar",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                l.Nombre = txtNombre.Text;
                l.Direccion = txtDireccion.Text;
                l.Email = txtEmail.Text;
                if (cbEstado.Text == "1" || cbEstado.Text == "True")
                    l.Estado = true;
                else
                    l.Estado = false;
                l.Telefono = Convert.ToInt32(txtTelefono.Text);

                lservice.Update(l);

                MessageBox.Show("Laboratorio editado");
                ClearFields();
                FillDataGridView();
            }
            catch (Exception) { }

        }

        private void dgLaboratorios_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                l = null;

                idLaboratorio = int.Parse(dgLaboratorios.SelectedRows[0].Cells["Codigo_Laboratorio"].Value.ToString());

                l = lservice.ReadByIdLaboratorio(idLaboratorio);

                txtNombre.Text = l.Nombre;
                txtDireccion.Text = l.Direccion;
                txtEmail.Text = l.Email;
                cbEstado.Text = l.Estado.ToString();
                txtTelefono.Text = l.Telefono.ToString();
            }
            catch (Exception) { }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgLaboratorios.SelectedRows.Count == 0) {
                MessageBox.Show(this, "Seleccione el laboratorio que desea eliminar", "Error al eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lservice.Delete(idLaboratorio);
            MessageBox.Show("Laboratorio eliminado");
            ClearFields();
            FillDataGridView();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }
    }
}
