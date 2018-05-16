using lad.org.entities2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lad.org.business
{
    public interface IProductoService : IService<Producto>
    {
        Producto ReadByIdProducto(int id);
        Producto ReadByNombreProducto(string nombre);
    }
}
