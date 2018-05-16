using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lad.org.entities2;
using lad.org.repository;

namespace lad.org.business
{
    public class ProductoService : IProductoService
    {
        private IProductoRepository prep = null;

        public ProductoService()
        {
            prep = new ProductoRepository();
        }

        public void Create(Producto p)
        {
            prep.Create(p);
        }

        public void Delete(int id)
        {
            prep.Delete(id);
        }

        public void Update(Producto p)
        {
            prep.Update(p);
        }

        public Producto ReadByIdProducto(int id)
        {
            return prep.ReadByIdProducto(id);
        }

        public List<Producto> Reader()
        {
            return prep.Reader();
        }

        public Producto ReadByNombreProducto(string nombre)
        {
            return prep.ReadByNombreProducto(nombre);
        }
    }
}
