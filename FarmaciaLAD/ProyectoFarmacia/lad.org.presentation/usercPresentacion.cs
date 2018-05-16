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
    public partial class usercPresentacion : UserControl
    {
        private IPresentacionService preservice = null;
        private IProductoService proservice = null;
        private Presentacion p = null;
        int idPresentacion;

        private static usercPresentacion _instance;

        public static usercPresentacion Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usercPresentacion();
                return _instance;
            }
        }

        public usercPresentacion()
        {
            InitializeComponent();
            preservice = new PresentacionService();
            proservice = new ProductoService();
            dgPresentacion.AutoGenerateColumns = false;
            dgProductos.AutoGenerateColumns = false;
        }

        private void FillDataGridViewPresentacion()
        {
            dgPresentacion.DataSource = preservice.Reader();
            dgProductos.DataSource = proservice.Reader();
        }
        private void btnRegistrarMarca_Click(object sender, EventArgs e)
        {
            CreatePresentacion();
        }

        private void usercPresentacion_Load(object sender, EventArgs e)
        {
            FillDataGridViewPresentacion();
        }

        private void CreatePresentacion()
        {
            if (txtNombrePresentacion.Text == "")
            {
                MessageBox.Show(this, "Complete los campos requeridos", "Error al eliminar",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            p = null;

            if (preservice.ReadByNombrePresentacion(txtNombrePresentacion.Text) == null)
            {
                p = new Presentacion();
                p.NombrePresentacion = txtNombrePresentacion.Text;
                preservice.Create(p);
                MessageBox.Show("Presentación registrada");
                ClearFields();
                FillDataGridViewPresentacion();
                return;
            }
            else
            {
                MessageBox.Show(this, "La presentación que intenta registrar ya existe", "Error al registrar",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void UpdatePresentacion()
        {
            if (dgPresentacion.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Seleccione la presentación que desea editar", "Error al editar",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            p.NombrePresentacion = txtNombrePresentacion.Text;

            if (preservice.ReadByNombrePresentacion(p.NombrePresentacion) != null)
            {
                MessageBox.Show(this, "Ya existe una presentación con ese nombre.", "Error al editar",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearFields();
                return;
            }
            
            preservice.Update(p);
            MessageBox.Show("Presentación actualizada");
            FillDataGridViewPresentacion();
            ClearFields();
            
        }

        private void ClearFields()
        {
            p = null;
            txtNombrePresentacion.Text = "";
        }

        private void btnEliminarPresentacion_Click(object sender, EventArgs e)
        {
            if (dgPresentacion.SelectedRows.Count == 0) {
                MessageBox.Show(this, "Seleccione la Presentacion que desea eliminar", "Error al eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }             
            preservice.Delete(idPresentacion);
            MessageBox.Show("Presentación eliminada");
            ClearFields();
            FillDataGridViewPresentacion();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgPresentacion_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                p = null;

                idPresentacion = int.Parse(dgPresentacion.SelectedRows[0].Cells["Codigo_Presentacion"].Value.ToString());

                p = preservice.ReadByIdPresentacion(idPresentacion);

                txtNombrePresentacion.Text = p.NombrePresentacion;
            }
            catch (Exception){ }
        }

        private void btnRegistrarPresentacion_Click(object sender, EventArgs e)
        {
            CreatePresentacion();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            UpdatePresentacion();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FillDataGridViewPresentacion();
        }
    }
}
