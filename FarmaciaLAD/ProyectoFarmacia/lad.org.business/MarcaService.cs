using lad.org.entities2;
using lad.org.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lad.org.business
{
    public class MarcaService : IMarcaService
    {

        IMarcaRepository mrep = null;
        public MarcaService()
        {
            mrep = new MarcaRepository();
        }

        public void Create(Marca m)
        {
            mrep.Create(m);
        }

        public void Delete(int id)
        {
            mrep.Delete(id);
        }

        public Marca ReadByIdMarca(int id)
        {
            return mrep.ReadByIdMarca(id);
        }

        public List<Marca> Reader()
        {
            return mrep.Reader();
        }

        public void Update(Marca m)
        {
            mrep.Update(m);
        }
        public Marca ReadByNombreMarca(string nombre)
        {
            return mrep.ReadByNombreMarca(nombre);
        }
    }
}
