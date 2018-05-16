using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lad.org.entities2;

namespace lad.org.repository
{
    public class IngresoRepository : IIngresoRepository
    {
        dbFarmaciaEntities context = null;

        public IngresoRepository()
        {
            context = new dbFarmaciaEntities();
        }

        public void Create(Ingreso i)
        {
            context.Ingreso.Add(i);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Ingreso.Remove(context.Ingreso.Where(x => x.Codigo_Ingreso == id).First());
            context.SaveChanges();
        }

        public List<Ingreso> Reader()
        {
            var resultado = context.Ingreso.ToList();
            return resultado;
        }

        public Ingreso ReadIngresoByID(int id)
        {
            var resultado = context.Ingreso.Find(id);
            return resultado;
        }

        public void Update(Ingreso i)
        {
            var resultado = context.Ingreso.FirstOrDefault(x => x.Codigo_Ingreso == i.Codigo_Ingreso);

            resultado.Codigo_Producto = i.Codigo_Producto;
            resultado.Fecha_Ingreso = i.Fecha_Ingreso;
            resultado.Tipo_Comprobante = i.Tipo_Comprobante;
            resultado.Cantidad = i.Cantidad;
            resultado.FechaVen = i.FechaVen;
            resultado.Total = i.Total;
            context.SaveChanges();
        }
    }
}
