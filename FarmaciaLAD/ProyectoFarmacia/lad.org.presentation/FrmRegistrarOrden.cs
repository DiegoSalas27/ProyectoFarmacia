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
    public partial class FrmRegistrarOrden : Form
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

        public FrmRegistrarOrden()
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
            this.dgProductos.DataSource = pservice.ReaderProducto();
            this.dgIngresos.DataSource = iservice.ListarIngreso();
        }

        private void FillComboProducto()
        { 
            var p = pservice.ReaderProducto();
            foreach (var n in p)
            {
                cbProducto.Items.Add(n.NombreProd);
            }
            
        }

        /*private void FillComboPresentacion()
        {
            var lista = prservice.ReaderPresentacion();

            lista.ForEach(x =>
            {
                this.cbPresentacion.Items.Add(new { Nombre = x.NombrePresentacion, Id = x.Codigo_Presentacion });
            });
        } */

        /*
    private void FillComboCategoria()
    {
        var lista = cservice.ReaderCategoria();

        lista.ForEach(x =>
        {
            this.cbCategoria.Items.Add(new { Nombre = x.NombreCategoria, Id = x.Codigo_Categoria });
        });
    }*/
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
            // cbMarca.SelectedIndex = p.Marca1.Codigo_Marca - 1;
            //cbCategoria.SelectedIndex = p.Categoria1.Codigo_Categoria - 1;
            //cbPresentacion.SelectedIndex = p.Presentacion1.Codigo_Presentacion - 1;
        }

        private void ClearFields()
        {

            this.p = null;
            this.c = null;
            this.m = null;
            this.pr = null;

            this.cbxProducto.SelectedIndex = -1;
            this.cbxComprobante.SelectedIndex = -1;

            lblCodProd.Text = "Código de producto:";
            lblPrecioUni.Text = "Precio unitario:";
            lblComposicion.Text = "Composición:";
            lblCantUni.Text = "Cantidad por unidad:";
            lblCategoria.Text = "Categoría:";
            lblMarca.Text = "Marca:";
            lblPresentacion.Text = "Presentación:";
            lblStock.Text = "Stock:";

            //this.cbMarca.SelectedIndex = -1;
            //this.cbPresentacion.SelectedIndex = -1;
            //this.cbCategoria.SelectedIndex = -1;
            //this.cbPrescripcion.Checked = false;
            //this.txtComposicion.Text = "";
            //this.txtNombre.Text = "";
        }

        private void CreateIngreso()
        {

            //if(p == null)
            //{
            //    int idMarca = m.Codigo_Marca;
            //
            //    p = new Producto();
            //    Marca marca = mservice.ReadByIdMarca(idMarca);
            //    p.Marca = marca.Codigo_Marca;
            //
            //    int idPresentacion = p.Codigo_Producto;
            //
            //    Presentacion presentacion = prservice.ReadByIdPresentacion(idPresentacion);
            //    p.Presentacion = presentacion.Codigo_Presentacion;
            //
            //    var idCategoria = cbCategoria.SelectedIndex + 1;
            //
            //    Categoria categoria = cservice.ReadByIdCategoria(idCategoria);
            //    p.Categoria = categoria.Codigo_Categoria;
            //
            //    p.Composicion = txtComposicion.Text;
            //    p.NombreProd = txtNombre.Text;
            //    p.Prescripcion = cbPrescripcion.Checked;
            //    p.FechaVen = dtFechaVenc.Value;
            //    p.Stock = 0;
            //    p.Precio = 0;
            //
            //    pservice.CreateProducto(p);
            //    
            //}
            //else
            //{
            //    this.ClearFields();
            //    
            //    return;
            //}
            ClearFields();
            Producto prod = pservice.ReadByNombreProducto(cbProducto.Text);
            int cantidad = Convert.ToInt32(nudCantidad.Text);
            i.Codigo_Producto = prod.Codigo_Producto;
            i.Fecha_Ingreso = dtFechaIngreso.Value;
            i.Tipo_Comprobante = cbComprobante.Text;
            i.Cantidad = Convert.ToInt32(nudCantidad.Text);
            i.Fecha_Vencimiento = dtFechaVenc.Value;
            i.Total = decimal.Parse(iservice.CalcularTotal(Convert.ToDouble(prod.Precio), cantidad).ToString());
            iservice.CreateIngreso(i);
        }

        private void UpdateProducto()
        {
           // Marca marca = mservice.ReadByIdMarca(cbMarca.SelectedIndex + 1);
           // p.Marca = marca.Codigo_Marca;
           // 
           //
           // Presentacion presentacion = prservice.ReadByIdPresentacion(cbPresentacion.SelectedIndex + 1);
           // p.Presentacion = presentacion.Codigo_Presentacion;
           //
           //
           // Categoria categoria = cservice.ReadByIdCategoria(cbCategoria.SelectedIndex + 1);
           // p.Categoria = categoria.Codigo_Categoria;
           // 
           // p.Composicion = txtComposicion.Text;
           // p.NombreProd = txtNombre.Text;
           // 
           // p.Prescripcion = cbPrescripcion.Checked;
           // p.FechaVen = dtFechaVenc.Value;
           //
           // pservice.UpdateProducto(p);
        }

        private void FrmRegistrarOrden_Load(object sender, EventArgs e)
        {
            this.FormatDateTime();
            this.FillComboProducto();
            //this.FillComboMarca();
            //this.FillComboCategoria();
            //this.FillComboPresentacion();
            this.FillDataGridView();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.CreateIngreso();
            this.FillDataGridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.UpdateProducto();
            this.FillDataGridView();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgIngresos.SelectedRows.Count == 0)
                return;

            int idIngreso = Convert.ToInt32(dgIngresos.SelectedRows[0].Cells["Codigo_Ingreso"].Value);

            try
            {
                iservice.DeleteIngreso(idIngreso);
                MessageBox.Show("Se ha eliminado el registro con éxito!");
                FillDataGridView();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Seleccione el producto que desea eliminar", "Error al eliminar", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.ClearFields();
        }

        private void dgProductos_MouseClick(object sender, MouseEventArgs e)
        {
            ClearFields();
            codigoProd = Convert.ToInt32(dgProductos.CurrentRow.Cells[0].Value);
            p = pservice.ReadByIdProducto(codigoProd);
            c = cservice.ReadByIdCategoria(p.Categoria);
            m = mservice.ReadByIdMarca(p.Marca);
            pr = prservice.ReadByIdPresentacion(p.Presentacion);
            actualizarLabels();
        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearFields();
            p = pservice.ReadByNombreProducto(cbProducto.Text);
            c = cservice.ReadByIdCategoria(p.Categoria);
            m = mservice.ReadByIdMarca(p.Marca);
            pr = prservice.ReadByIdPresentacion(p.Presentacion);
            actualizarLabels();
        }

        private void cbxComprobante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbComprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            i.Tipo_Comprobante = cbComprobante.Text;
        }
    }
}
