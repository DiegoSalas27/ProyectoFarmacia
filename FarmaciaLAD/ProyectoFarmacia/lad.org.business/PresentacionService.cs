using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lad.org.entities2;
using lad.org.repository;

namespace lad.org.business
{
    public class PresentacionService :IPresentacionService
    {
        private IPresentacionRepository prep = null;

        public PresentacionService()
        {
            prep = new PresentacionRepository();
        }

        public void Create(Presentacion p)
        {
            prep.Create(p);
        }

        public void Delete(int id)
        {
            prep.Delete(id);
        }

        public Presentacion ReadByIdPresentacion(int id)
        {
            return prep.ReadByIdPresentacion(id);
        }

        public List<Presentacion> Reader()
        {
            return prep.Reader();
        }

        public void Update(Presentacion p)
        {
            prep.Update(p);
        }

        public Presentacion ReadByNombrePresentacion(string nombre)
        {
            return prep.ReadByNombrePresentacion(nombre);
        }
    }
}
