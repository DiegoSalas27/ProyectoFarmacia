using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lad.org.entities2;

namespace lad.org.repository
{
    public class MarcaRepository : IMarcaRepository
    {

        private dbFarmaciaEntities context = null;

        public MarcaRepository()
        {
            context = new dbFarmaciaEntities();
        }

        public void Create(Marca m)
        {
            context.Marca.Add(m);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Producto.RemoveRange(context.Producto.Where(x => x.Marca1.Codigo_Marca == id));
            context.Marca.Remove(context.Marca.Where(x => x.Codigo_Marca == id).First());
            context.SaveChanges();
        }

        public Marca ReadByIdMarca(int id)
        {
            var marca = (from mar in context.Marca
                         where mar.Codigo_Marca == id
                         select mar).ToList().FirstOrDefault();

            return marca;
        }

        public List<Marca> Reader()
        {
            var listMarcas = (from mar in context.Marca
                              select mar).ToList();

            return listMarcas;
        }

        public Marca ReadByNombreMarca(string nombre)
        {
            var resultado = context.Marca.FirstOrDefault(x => x.NombreMarca == nombre);
            return resultado;
        }

        public void Update(Marca m)
        {
            var marca = context.Marca.FirstOrDefault(x => x.Codigo_Marca == m.Codigo_Marca);
            marca.NombreMarca = m.NombreMarca;
            context.SaveChanges();
        }

    }
}
