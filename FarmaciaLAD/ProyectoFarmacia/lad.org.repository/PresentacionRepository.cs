using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lad.org.entities2;

namespace lad.org.repository
{
    public class PresentacionRepository : IPresentacionRepository
    {
        dbFarmaciaEntities context = null;
        public PresentacionRepository()
        {
            context = new dbFarmaciaEntities();
        }
        public void Create(Presentacion p)
        {
            context.Presentacion.Add(p);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Producto.RemoveRange(context.Producto.Where(x => x.Presentacion1.Codigo_Presentacion == id));
            context.Presentacion.Remove(context.Presentacion.Where(x => x.Codigo_Presentacion == id).First());
            context.SaveChanges();
        }

        public Presentacion ReadByIdPresentacion(int id)
        {
            var presentacion = (from pres in context.Presentacion
                                where pres.Codigo_Presentacion == id
                                select pres).ToList().FirstOrDefault();
            return presentacion;
        }

        public Presentacion ReadByNombrePresentacion(string nombre)
        {
            var resultado = context.Presentacion.FirstOrDefault(x => x.NombrePresentacion == nombre);
            return resultado;
        }

        public List<Presentacion> Reader()
        {
            var listPresentacion = (from pres in context.Presentacion
                                    select pres).ToList();

            return listPresentacion;
        }

        public void Update(Presentacion p)
        {
            var presentacion = (from pres in context.Presentacion
                                where pres.Codigo_Presentacion == p.Codigo_Presentacion
                                select pres).ToList().FirstOrDefault();

            presentacion.NombrePresentacion = p.NombrePresentacion;
            context.SaveChanges();
        }
    }
}
