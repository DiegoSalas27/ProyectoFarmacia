using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lad.org.entities2;

namespace lad.org.repository
{
    public class ProductoRepository : IProductoRepository
    {

        dbFarmaciaEntities context = null;

        public ProductoRepository()
        {
            context = new dbFarmaciaEntities();
        }

        public void Create(Producto p)
        {
            context.Producto.Add(p);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Producto.Remove(context.Producto.Where(x => x.Codigo_Producto == id).First());
            context.SaveChanges();
        }

        public Producto ReadByIdProducto(int id)
        {
            return context.Producto.Find(id);
        }

        public Producto ReadByNombreProducto(string nombre)
        {
            return context.Producto.FirstOrDefault(x => x.NombreProd == nombre);
        }

        public List<Producto> Reader()
        {
            return context.Producto.ToList();
        }

        public void Update(Producto p)
        {
            var producto = context.Producto.Where(x => x.Codigo_Producto == p.Codigo_Producto).First();

            producto.NombreProd = p.NombreProd;
            producto.Composicion = p.Composicion;
            producto.Categoria = p.Categoria;
            producto.Stock = p.Stock;
            producto.Marca = p.Marca;
            producto.Precio = p.Precio;
            producto.Presentacion = p.Presentacion;

            context.SaveChanges();
        }
    }
}
