using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lad.org.entities2;

namespace lad.org.repository
{
    public class CategoriaRepository : ICategoriaRepository
    {

        dbFarmaciaEntities context = null;

        public CategoriaRepository()
        {
            context = new dbFarmaciaEntities();
        }

        public void Create(Categoria c)
        {
            context.Categoria.Add(c);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Producto.RemoveRange(context.Producto.Where(x => x.Categoria1.Codigo_Categoria == id));
            context.Categoria.Remove(context.Categoria.Where(x => x.Codigo_Categoria == id).First());
            context.SaveChanges();
        }

        public Categoria ReadByIdCategoria(int id)
        {
            var categoria = (from cat in context.Categoria
                             where cat.Codigo_Categoria == id
                             select cat).ToList().FirstOrDefault();

            return categoria;
        }

        public List<Categoria> Reader()
        {
            var listCategorias = context.Categoria.ToList();

            return listCategorias;
        }

        public Categoria ReadByNombreCategoria(string nombre)
        {
            var resultado = context.Categoria.FirstOrDefault(x => x.NombreCategoria == nombre);
            return resultado;
        }

        public void Update(Categoria c)
        {
            var categoria = (from cat in context.Categoria
                             where cat.Codigo_Categoria == c.Codigo_Categoria
                             select cat).ToList().FirstOrDefault();

            categoria.NombreCategoria = c.NombreCategoria;
            context.SaveChanges();
        }
    }
}
