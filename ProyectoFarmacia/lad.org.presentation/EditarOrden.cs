using lad.org.business;
using lad.org.entities2;
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
    public partial class EditarOrden : Form
    {
        private IIngresoService iservice;
        private IProductoService pservice;
        public int Codigo_ingreso { get; set; }
        private DataGridView dgvIngreso;

        public EditarOrden(int codigo, DataGridView dgvIngreso)
        {
            InitializeComponent();
            iservice = new IngresoService();
            pservice = new ProductoService();
            Codigo_ingreso = codigo;
            this.dgvIngreso = dgvIngreso;
            FormatDateTime();
            Cargar();
        }

        public void FormatDateTime()
        {
            dtFechaIngreso.Format = DateTimePickerFormat.Custom;
            dtFechaIngreso.CustomFormat = "dd MMM yyyy";
            dtFechaVencimiento.Format = DateTimePickerFormat.Custom;
            dtFechaVencimiento.CustomFormat = "dd MMM yyyy";
        }
        public void Cargar()
        {
            var ingreso = iservice.ReadIngresoByID(Codigo_ingreso);

            dtFechaIngreso.Text = ingreso.Fecha_Ingreso.ToString();
            cbComprobante.Text = ingreso.Tipo_Comprobante;
            nudCantidad.Text = ingreso.Cantidad.ToString();
            dtFechaVencimiento.Text = ingreso.FechaVen.ToString();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var ingreso = iservice.ReadIngresoByID(Codigo_ingreso);
            var producto = pservice.ReadByIdProducto(ingreso.Codigo_Producto);
            //actualizamos el stock de producto
            producto.Stock = producto.Stock - (ingreso.Cantidad - Convert.ToInt32(nudCantidad.Text));
            ingreso.Fecha_Ingreso = dtFechaIngreso.Value;
            ingreso.FechaVen = dtFechaVencimiento.Value;
            ingreso.Tipo_Comprobante = cbComprobante.Text;
            ingreso.Codigo_Ingreso = Codigo_ingreso;
            ingreso.Codigo_Producto = producto.Codigo_Producto;
            ingreso.Cantidad = Convert.ToInt32(nudCantidad.Text);
            ingreso.Total = decimal.Parse(iservice.CalcularTotal(Convert.ToDouble(producto.Precio), ingreso.Cantidad).ToString());
            iservice.Update(ingreso);
            pservice.Update(producto);
            MessageBox.Show("Se ha actualizado la orden de ingreso.");
            this.Close();
        }

        private void EditarOrden_Load(object sender, EventArgs e)
        {
            dgvIngreso.DataSource = iservice.Reader();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
