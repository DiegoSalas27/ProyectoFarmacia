using lad.org.entities2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lad.org.repository
{
    public interface IIngresoRepository : IRepositorio<Ingreso>
    {
        Ingreso ReadIngresoByID(int id);
    }
}
