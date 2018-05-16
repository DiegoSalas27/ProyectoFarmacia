using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lad.org.entities2;
using lad.org.repository;

namespace lad.org.business
{
    public class IngresoService : IIngresoService
    {
        IIngresoRepository IRep = null;

        public IngresoService()
        {
            IRep = new IngresoRepository();
        }
        public double CalcularTotal(double precio, int cantidad)
        {
            return precio * cantidad;
        }

        public void Create(Ingreso t)
        {
            IRep.Create(t);
        }

        public void Delete(int id)
        {
            IRep.Delete(id);
        }

        public List<Ingreso> Reader()
        {
            return IRep.Reader();
        }

        public Ingreso ReadIngresoByID(int id)
        {
            return IRep.ReadIngresoByID(id);
        }

        public void Update(Ingreso t)
        {
           
            IRep.Update(t);
        }
    }
}
