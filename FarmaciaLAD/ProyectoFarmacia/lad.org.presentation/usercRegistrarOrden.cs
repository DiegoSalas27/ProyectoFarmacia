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
    public partial class usercRegistrarOrden : UserControl
    {
        private IProductoService pservice = null;
        private IMarcaService mservice = null;
        private IPresentacionService prservice = null;
        private ICategoriaService cservice = null;
        private IIngresoService iservice = null;

        private Producto p = new Producto();
        private Marca m = new Marca();
        private Presentacion pr = new Presentacion();
        private Categoria c = new Categoria();
        private Ingreso i = new Ingreso();

        int codigoProd;

        private static usercRegistrarOrden _instance;

        public static usercRegistrarOrden Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usercRegistrarOrden();
                return _instance;
            }
        }

        public usercRegistrarOrden()
        {
            InitializeComponent();
            dgProductos.AutoGenerateColumns = false;
            dgIngresos.AutoGenerateColumns = false;
            pservice = new ProductoService();
            mservice = new MarcaService();
            prservice = new PresentacionService();
            cservice = new CategoriaService();
            iservice = new IngresoService();
        }

        private void FormatDateTime()
        {
            this.dtFechaVenc.Format = DateTimePickerFormat.Custom;
            this.dtFechaVenc.CustomFormat = "dd MMM yyyy";
            this.dtFechaIngreso.Format = DateTimePickerFormat.Custom;
            this.dtFechaIngreso.CustomFormat = "dd MMM yyyy";
        }

        private void FillDataGridView()
        {
            this.dgProductos.DataSource = pservice.Reader();
            this.dgIngresos.DataSource = iservice.Reader();
        }

        private void actualizarLabels()
        {
            lblCodProd.Text = lblCodProd.Text + " " + p.Codigo_Producto.ToString();
            lblComposicion.Text = lblComposicion.Text + " " + p.Composicion;
            lblCantUni.Text = lblCantUni.Text + " " + p.Cantidad_Por_Unidad_gr_.ToString();
            lblCategoria.Text = lblCategoria.Text + " " + c.NombreCategoria;
            lblMarca.Text = lblMarca.Text + " " + m.NombreMarca;
            lblPresentacion.Text = lblPresentacion.Text + " " + pr.NombrePresentacion;
            lblStock.Text = lblStock.Text + " " + p.Stock.ToString();
            string redondeo = p.Precio.ToString("n");
            lblPrecioUni.Text = lblPrecioUni.Text + " " + redondeo;
        }

        private void ClearFields()
        {

            p = null;
            c = null;
            m = null;
            pr = null;

            cbComprobante.SelectedIndex = -1;

            lblCodProd.Text = "Código de producto:";
            lblPrecioUni.Text = "Precio unitario:";
            lblComposicion.Text = "Composición:";
            lblCantUni.Text = "Cantidad por unidad:";
            lblCategoria.Text = "Categoría:";
            lblMarca.Text = "Marca:";
            lblPresentacion.Text = "Presentación:";
            lblStock.Text = "Stock:";
        }

        private void ClearFields2()
        {
            this.cbComprobante.SelectedIndex = -1;

            lblCodProd.Text = "Código de producto:";
            lblPrecioUni.Text = "Precio unitario:";
            lblComposicion.Text = "Composición:";
            lblCantUni.Text = "Cantidad por unidad:";
            lblCategoria.Text = "Categoría:";
            lblMarca.Text = "Marca:";
            lblPresentacion.Text = "Presentación:";
            lblStock.Text = "Stock:";
        }

        private void CreateIngreso()
        {
            try
            {
                if (nudCantidad.Text != "0" && cbComprobante.Text != "" && cbxProducto.Text != "")
                {
                    Producto prod = pservice.ReadByNombreProducto(cbxProducto.Text);
                    int cantidad = Convert.ToInt32(nudCantidad.Text);
                    i.Codigo_Producto = prod.Codigo_Producto;
                    i.Fecha_Ingreso = dtFechaIngreso.Value;
                    i.Tipo_Comprobante = cbComprobante.Text;
                    i.Cantidad = Convert.ToInt32(nudCantidad.Text);
                    i.FechaVen = dtFechaVenc.Value;
                    i.Total = decimal.Parse(iservice.CalcularTotal(Convert.ToDouble(prod.Precio), cantidad).ToString());
                    iservice.Create(i);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show(this, "Complete los campos requeridos", "Error al eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception) { }
        }
        private void FillComboProducto()
        {
            var p = pservice.Reader();
            foreach (var n in p)
            {
                cbxProducto.Items.Add(n.NombreProd);
            }

        }
        private void usercRegistrarOrden_Load(object sender, EventArgs e)
        {
            this.FormatDateTime();
            this.FillComboProducto();
            this.FillDataGridView();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.CreateIngreso();
            this.FillDataGridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgIngresos.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Seleccione una fila", "Error al eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ingreso = new Ingreso();
            ingreso = iservice.ReadIngresoByID(int.Parse(dgIngresos.SelectedRows[0].Cells["Codigo_Ingreso"].Value.ToString()));
            EditarOrden frmEditar = new EditarOrden(ingreso.Codigo_Ingreso, dgIngresos);
            frmEditar.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgIngresos.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Seleccione el registro que desea eliminar", "Error al eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idIngreso = Convert.ToInt32(dgIngresos.SelectedRows[0].Cells["Codigo_Ingreso"].Value);

            iservice.Delete(idIngreso);
            MessageBox.Show("Se ha eliminado el registro con éxito!");
            FillDataGridView();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.ClearFields();
        }

        private void cbComprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            i.Tipo_Comprobante = cbComprobante.Text;
        }

        private void cbxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearFields();
            p = pservice.ReadByNombreProducto(cbxProducto.Text);
            c = cservice.ReadByIdCategoria(p.Categoria);
            m = mservice.ReadByIdMarca(p.Marca);
            pr = prservice.ReadByIdPresentacion(p.Presentacion);
            actualizarLabels();
        }

        private void dgProductos_SelectionChanged(object sender, EventArgs e)
        {
            try {
                codigoProd = Convert.ToInt32(dgProductos.CurrentRow.Cells[0].Value);
                p = pservice.ReadByIdProducto(codigoProd);
                c = cservice.ReadByIdCategoria(p.Categoria);
                m = mservice.ReadByIdMarca(p.Marca);
                pr = prservice.ReadByIdPresentacion(p.Presentacion);
                cbxProducto.Text = p.NombreProd;
                ClearFields2();
                actualizarLabels();
            }
            catch (Exception) { }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FillComboProducto();
            FillDataGridView();
        }
    }
}
