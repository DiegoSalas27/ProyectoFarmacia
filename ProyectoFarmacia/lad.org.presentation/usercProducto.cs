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
    public partial class usercProducto : UserControl
    {

        private IProductoService pservice = null;
        private IMarcaService mservice = null;
        private IPresentacionService prservice = null;
        private ICategoriaService cservice = null;
        private ILaboratorioService lservice = null;

        private Producto p = null;
        private Marca m = null;
        private Presentacion pr = null;
        private Categoria c = null;
        private Laboratorio l = null;
        private int id;
        private String nombreActual;

        private static usercProducto _instance;

        public static usercProducto Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usercProducto();
                return _instance;
            }
        }

        public usercProducto()
        {
            InitializeComponent();
            dgProductos.AutoGenerateColumns = false;
            pservice = new ProductoService();
            mservice = new MarcaService();
            prservice = new PresentacionService();
            cservice = new CategoriaService();
            lservice = new LaboratorioService();
        }

        private void FormatCombos()
        {
            cbMarca.DisplayMember = "Nombre";
            cbMarca.ValueMember = "Id";
            cbCategoria.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "Id";
            cbPresentacion.DisplayMember = "Nombre";
            cbPresentacion.ValueMember = "Id";
            cbLaboratorio.DisplayMember = "Nombre";
            cbLaboratorio.ValueMember = "Id";
        }

        private void FillDataGridView()
        {
            dgProductos.DataSource = pservice.Reader();
        }

        private void FillComboMarca()
        {
            var lista = mservice.Reader();

            lista.ForEach(x =>
            {
                this.cbMarca.Items.Add(new { Nombre = x.NombreMarca, Id = x.Codigo_Marca });
            });

        }

        private void FillComboLaboratorio()
        {
            var lista = lservice.Reader();

            lista.ForEach(x =>
            {
                this.cbLaboratorio.Items.Add(new { Nombre = x.Nombre, Id = x.Codigo_Laboratorio });
            });

        }

        private void FillComboPresentacion()
        {
            var lista = prservice.Reader();

            lista.ForEach(x =>
            {
                this.cbPresentacion.Items.Add(new { Nombre = x.NombrePresentacion, Id = x.Codigo_Presentacion });
            });
        }

        private void FillComboCategoria()
        {
            var lista = cservice.Reader();

            lista.ForEach(x =>
            {
                this.cbCategoria.Items.Add(new { Nombre = x.NombreCategoria, Id = x.Codigo_Categoria });
            });
        }

        private void ClearFields()
        {
            p = null;
            m = null;
            pr = null;
            c = null;
            l = null;

            cbMarca.SelectedIndex = -1;
            cbPresentacion.SelectedIndex = -1;
            cbCategoria.SelectedIndex = -1;
            cbLaboratorio.SelectedIndex = -1;
            txtComposicion.Text = "";
            txtNombre.Text = "";
            nudCantidad.Text = "0.00";
            nudPrecio.Text = "0";
            nudStock.Text = "0.00";
            nudStock.Enabled = false;

        }


        private void CreateProducto()
        {
            if (pservice.ReadByNombreProducto(txtNombre.Text) != null)
            {
                MessageBox.Show(this, "El nombre del producto que registrar ya existe", "Error al editar",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            p = null;
   
            if (txtNombre.Text != "" && txtComposicion.Text != "" && cbCategoria.Text != "" && cbLaboratorio.Text != ""
                && cbMarca.Text != "" && cbPresentacion.Text != "" && nudCantidad.Value != 0 && nudPrecio.Value != 0)
            {
                p = new Producto();

                m = mservice.ReadByNombreMarca(cbMarca.Text);
                p.Marca = m.Codigo_Marca;

                pr = prservice.ReadByNombrePresentacion(cbPresentacion.Text);
                p.Presentacion = pr.Codigo_Presentacion;

                c = cservice.ReadByNombreCategoria(cbCategoria.Text);
                p.Categoria = c.Codigo_Categoria;

                l = lservice.ReadByNombreLaboratorio(cbLaboratorio.Text);
                p.Laboratorio = l.Codigo_Laboratorio;

                p.Composicion = txtComposicion.Text;
                p.NombreProd = txtNombre.Text;
                p.Stock = 0;
                p.Precio = Convert.ToInt32(nudCantidad.Text);
                p.Cantidad_Por_Unidad_gr_ = Convert.ToInt32(nudCantidad.Text);

                pservice.Create(p);
                FillDataGridView();
                ClearFields();
                return;                 
            }
            else
            {
                MessageBox.Show(this, "Complete los campos requeridos", "Error al editar",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearFields();
        }


        private void UpdateProducto()
        {
            if (dgProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Seleccione el producto que desea editar", "Error al editar",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            p.NombreProd = txtNombre.Text;

            try
            {
                if (pservice.ReadByNombreProducto(p.NombreProd) == null || p.NombreProd == nombreActual)
                {
                    m = mservice.ReadByNombreMarca(cbMarca.Text);

                    pr = prservice.ReadByNombrePresentacion(cbPresentacion.Text);

                    c = cservice.ReadByNombreCategoria(cbCategoria.Text);

                    l = lservice.ReadByNombreLaboratorio(cbLaboratorio.Text);

                    p.Marca = m.Codigo_Marca;
                    p.Presentacion = pr.Codigo_Presentacion;
                    p.Laboratorio = l.Codigo_Laboratorio;
                    p.Categoria = c.Codigo_Categoria;
                    p.Composicion = txtComposicion.Text;
                    p.Precio = nudPrecio.Value;
                    p.Cantidad_Por_Unidad_gr_ = Convert.ToInt32(nudCantidad.Text);
                    p.Stock = Convert.ToInt32(nudStock.Text);

                    pservice.Update(p);
                    MessageBox.Show("Producto actualizado");
                    FillDataGridView();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show(this, "El nombre que desea actualizar ya existe", "Error al editar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearFields();
                }
            }
            catch (Exception) { }
          
        }

        private void usercProducto_Load(object sender, EventArgs e)
        {
            FormatCombos();
            FillComboMarca();
            FillComboCategoria();
            FillComboPresentacion();
            FillComboLaboratorio();
            FillDataGridView();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            CreateProducto();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            UpdateProducto();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Seleccione el producto que desea eliminar", "Error al eliminar",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = p.NombreProd;
            pservice.Delete(id);
            FillDataGridView();
            MessageBox.Show("Se ha eliminado " + nombre + " con éxito!");
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.ClearFields();
        }

        private void dgProductos_SelectionChanged(object sender, EventArgs e)
        {
            try {
                p = null;
                nombreActual = "";

                id = Convert.ToInt32(dgProductos.SelectedRows[0].Cells["Codigo_Producto"].Value);

                p = pservice.ReadByIdProducto(id);

                nombreActual = txtNombre.Text = p.NombreProd;
                txtComposicion.Text = p.Composicion;
                nudPrecio.Text = p.Precio.ToString();
                nudCantidad.Text = p.Cantidad_Por_Unidad_gr_.ToString();
                nudStock.Text = p.Stock.ToString();
    
                cbMarca.Text = mservice.ReadByIdMarca(p.Marca).NombreMarca;
                cbCategoria.Text = cservice.ReadByIdCategoria(p.Categoria).NombreCategoria;
                cbPresentacion.Text = prservice.ReadByIdPresentacion(p.Presentacion).NombrePresentacion;
                cbLaboratorio.Text = lservice.ReadByIdLaboratorio(p.Laboratorio).Nombre;


            }
            catch (Exception) { }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }
    }
}
