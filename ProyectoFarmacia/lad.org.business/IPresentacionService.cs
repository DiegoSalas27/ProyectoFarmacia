using lad.org.entities2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lad.org.business
{
    public interface IPresentacionService : IService<Presentacion>
    {
        Presentacion ReadByIdPresentacion(int id);
        Presentacion ReadByNombrePresentacion(string nombre);
    }
}
