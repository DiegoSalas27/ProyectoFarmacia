using lad.org.entities2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lad.org.repository
{
    public interface ICategoriaRepository : IRepositorio<Categoria>
    {
        Categoria ReadByIdCategoria(int id);
        Categoria ReadByNombreCategoria(string nombre);
    }
}
