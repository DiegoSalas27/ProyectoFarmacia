using lad.org.business;
using lad.org.domain;
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
    public partial class FrmRegistrarMarca : Form
    {
        private IMarcaService mservice = null;
        private Marca m = null;
        int idMarca;


        public FrmRegistrarMarca()
        {
            InitializeComponent();
            mservice = new MarcaService();
        }

        private void FillDataGridViewMarca()
        {
            this.dgMarcas.DataSource = mservice.ReaderMarca();
        }

        private void FrmRegistrarMarca_Load(object sender, EventArgs e)
        {
            FillDataGridViewMarca();
        }

        private void CreateMarca()
        {
            if(m == null)
            {
                m = new Marca();
                m.NombreMarca = txtNombreMarca.Text;
                mservice.CreateMarca(m);
                ClearFields();
                FillDataGridViewMarca();
                return;
            }
            else
            {
                ClearFields();
                return;
            }
        }

        private void UpdateMarca()
        {
            var marca = new Marca();
            marca.Codigo_Marca = int.Parse(dgMarcas.SelectedRows[0].Cells["Codigo_Marca"].Value.ToString());
            marca.NombreMarca = txtNombreMarca.Text;
            mservice.UpdateMarca(marca);
            FillDataGridViewMarca();
            ClearFields();
        }

        private void DeleteMarca()
        {
            mservice.DeleteMarca(m);
            ClearFields();
            FillDataGridViewMarca();
        }

        private void SelectMarcaFromDgMarca()
        {
            try
            {
                idMarca = int.Parse(dgMarcas.SelectedRows[0].Cells["Codigo_Marca"].Value.ToString());

                m = mservice.ReadByIdMarca(idMarca);

                txtNombreMarca.Text = m.NombreMarca;
            }
            catch (Exception)
            {

            }

            
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
            MessageBox.Show("Marca Actualizada");
        }

        private void dgMarcas_SelectionChanged(object sender, EventArgs e)
        {
            SelectMarcaFromDgMarca();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteMarca();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Seleccione la marca que desea eliminar", "Error al eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
