using lad.org.entities2;
using lad.org.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lad.org.business
{
    public class LaboratorioService : ILaboratorioService
    {
        ILaboratorioRepository lrep = null;
        public LaboratorioService()
        {
            lrep = new LaboratorioRepository();
        }

        public void Create(Laboratorio l)
        {
            lrep.Create(l);
        }

        public void Delete(int id)
        {
            lrep.Delete(id);
        }

        public bool ReadByDireccion(string direccion, int telefono, string email, string nombre)
        {
            return lrep.ReadByDireccion(direccion, telefono, email, nombre);
        }

        public Laboratorio ReadByIdLaboratorio(int id)
        {
            return lrep.ReadByIdLaboratorio(id);
        }

        public Laboratorio ReadByNombreLaboratorio(string nombre)
        {
            return lrep.ReadByNombreLaboratorio(nombre);
        }

        public List<Laboratorio> Reader()
        {
            return lrep.Reader();
        }

        public void Update(Laboratorio l)
        {
            lrep.Update(l);
        }
    }
}
