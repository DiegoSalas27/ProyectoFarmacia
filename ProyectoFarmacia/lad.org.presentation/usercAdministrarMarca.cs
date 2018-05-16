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
    public partial class usercAdministrarMarca : UserControl
    {
        private IMarcaService mservice = null;
        private IProductoService pservice = null;
        private Marca m = null;
        int idMarca;

        private static usercAdministrarMarca _instance;

        public static usercAdministrarMarca Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usercAdministrarMarca();
                return _instance;
            }
        }

        public usercAdministrarMarca()
        {
            InitializeComponent();
            mservice = new MarcaService();
            pservice = new ProductoService();
            dgMarca.AutoGenerateColumns = false;
        }

        private void FillDataGridViewMarca()
        {
            dgMarca.DataSource = mservice.Reader();
            dgProductos.DataSource = pservice.Reader();
        }

        private void usercAdministrarMarca_Load(object sender, EventArgs e)
        {
            FillDataGridViewMarca();
        }

        private void CreateMarca()
        {
            if (txtNombreMarca.Text == "")
            {
                MessageBox.Show(this, "Complete los campos requeridos", "Error al eliminar",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            m = null;

            if (mservice.ReadByNombreMarca(txtNombreMarca.Text) == null)
            {
                var m = new Marca();
                m.NombreMarca = txtNombreMarca.Text;
                mservice.Create(m);
                MessageBox.Show("Marca registrada");
                ClearFields();
                FillDataGridViewMarca();
                return;
            }
            else {
                MessageBox.Show(this, "La marca que intenta registrar ya existe", "Error al registrar",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void UpdateMarca()
        {
            if (dgMarca.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Seleccione la marca que desea editar", "Error al editar",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            m.NombreMarca = txtNombreMarca.Text;

            if (mservice.ReadByNombreMarca(m.NombreMarca) != null)
            {
                MessageBox.Show(this, "Ya existe una marca con ese nombre.", "Error al editar",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearFields();
                return;
            }

            mservice.Update(m);
            MessageBox.Show("Marca actualizada");
            FillDataGridViewMarca();
            ClearFields();
        }

        private void ClearFields()
        {
            m = null;
            txtNombreMarca.Text = "";
        }

        private void btnRegistrarMarca_Click(object sender, EventArgs e)
        {
            CreateMarca();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            UpdateMarca();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            if (dgMarca.SelectedRows.Count == 0) {
                MessageBox.Show(this, "Seleccione la marca que desea eliminar", "Error al eliminar",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            mservice.Delete(idMarca);
            MessageBox.Show("Marca eliminada");
            ClearFields();
            FillDataGridViewMarca();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgMarca_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                m = null;

                idMarca = int.Parse(dgMarca.SelectedRows[0].Cells["Codigo_Marca"].Value.ToString());

                m = mservice.ReadByIdMarca(idMarca);

                txtNombreMarca.Text = m.NombreMarca;
            }
            catch (Exception) { }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FillDataGridViewMarca();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
