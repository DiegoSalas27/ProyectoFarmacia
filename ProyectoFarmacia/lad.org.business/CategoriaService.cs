using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lad.org.entities2;
using lad.org.repository;

namespace lad.org.business
{
    public class CategoriaService : ICategoriaService
    {
        ICategoriaRepository crep = null;
        public CategoriaService()
        {
            crep = new CategoriaRepository();
        }
        public void Create(Categoria c)
        {
            crep.Create(c);
        }

        public void Delete(int id)
        {
            crep.Delete(id);
        }

        public Categoria ReadByIdCategoria(int id)
        {
            return crep.ReadByIdCategoria(id);
        }

        public List<Categoria> Reader()
        {
            return crep.Reader();
        }

        public void Update(Categoria c)
        {
            crep.Update(c);
        }
        public Categoria ReadByNombreCategoria(string nombre)
        {
            return crep.ReadByNombreCategoria(nombre);
        }
    }
}
