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
    public partial class usercAdministrarCategoria : UserControl
    {
        private ICategoriaService cservice = null;
        private IProductoService pservice = null;
        private Categoria c = null;
        int idCategoria;

        private static usercAdministrarCategoria _instance;

        public static usercAdministrarCategoria Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usercAdministrarCategoria();
                return _instance;
            }
        }

        public usercAdministrarCategoria()
        {
            InitializeComponent();
            cservice = new CategoriaService();
            pservice = new ProductoService();
            dgCategoria.AutoGenerateColumns = false;
        }

        private void FillDataGridViewCategoria()
        {
            this.dgCategoria.DataSource = cservice.Reader();
            this.dgProductos.DataSource = pservice.Reader();
        }


        private void btnRegistrarMarca_Click(object sender, EventArgs e)
        {
            CreateCategoria();
        }

        private void usercAdministrarCategoria_Load(object sender, EventArgs e)
        {
            FillDataGridViewCategoria();
        }

        private void CreateCategoria()
        {
            if (txtNombreCategoria.Text == "")
            {
                MessageBox.Show(this, "Complete los campos requeridos", "Error al eliminar",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            c = null;

            if (cservice.ReadByNombreCategoria(txtNombreCategoria.Text) == null)
            {
                c = new Categoria();
                c.NombreCategoria = txtNombreCategoria.Text;
                cservice.Create(c);
                MessageBox.Show("Categoría registrada");
                ClearFields();
                FillDataGridViewCategoria();
                return;
            }
            else
            {
                MessageBox.Show(this, "La categoría que intenta registrar ya existe", "Error al registrar",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void UpdateCategoria()
        {
            if (dgCategoria.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Seleccione la categoría que desea editar", "Error al editar",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            c.NombreCategoria = txtNombreCategoria.Text;

            if (cservice.ReadByNombreCategoria(c.NombreCategoria) != null)
            {
                MessageBox.Show(this, "Ya existe una categoria con ese nombre.", "Error al editar",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearFields();
                return;
            }

            cservice.Update(c);
            MessageBox.Show("Categoría actualizada");
            FillDataGridViewCategoria();
            ClearFields();
        }

        private void ClearFields()
        {
            c = null;
            txtNombreCategoria.Text = "";
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            UpdateCategoria();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (dgCategoria.SelectedRows.Count == 0) {
                MessageBox.Show(this, "Seleccione la categoria que desea eliminar", "Error al eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cservice.Delete(idCategoria);
            MessageBox.Show("Categoría eliminada");
            ClearFields();
            FillDataGridViewCategoria();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgCategoria_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                c = null;

                idCategoria = int.Parse(dgCategoria.SelectedRows[0].Cells["Codigo_Categoria"].Value.ToString());

                c = cservice.ReadByIdCategoria(idCategoria);

                txtNombreCategoria.Text = c.NombreCategoria;
            }
            catch (Exception) { }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FillDataGridViewCategoria();
        }
    }
}
