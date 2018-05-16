using lad.org.entities2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lad.org.business
{
    public interface IIngresoService : IService<Ingreso>
    {
        Ingreso ReadIngresoByID(int id);
        double CalcularTotal(double precio, int cantidad);
    }
}
