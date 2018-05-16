using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lad.org.entities2;

namespace lad.org.repository
{
    public class LaboratorioRepository : ILaboratorioRepository
    {

        dbFarmaciaEntities context = null;

        public LaboratorioRepository()
        {
            context = new dbFarmaciaEntities();
        }

        public void Create(Laboratorio l)
        {
            context.Laboratorio.Add(l);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Producto.RemoveRange(context.Producto.Where(x => x.Laboratorio1.Codigo_Laboratorio == id));
            context.Laboratorio.Remove(context.Laboratorio.Where(x => x.Codigo_Laboratorio == id).First());
            context.SaveChanges();
        }

        public bool ReadByDireccion(string direccion, int telefono, string email, string nombre)
        {
            return context.Laboratorio.Any(x => x.Direccion == direccion || x.Telefono == telefono || x.Email == email || x.Nombre == nombre);
        }

        public Laboratorio ReadByIdLaboratorio(int id)
        {
            var resultado = context.Laboratorio.Find(id);
            return resultado;
        }

        public Laboratorio ReadByNombreLaboratorio(string nombre)
        {
            var resultado = context.Laboratorio.FirstOrDefault(x => x.Nombre == nombre);
            return resultado;
        }

        public List<Laboratorio> Reader()
        {
            var resultado = context.Laboratorio.ToList();
            return resultado;
        }

        public void Update(Laboratorio l)
        {
            var resultado = context.Laboratorio.FirstOrDefault(x => x.Codigo_Laboratorio == l.Codigo_Laboratorio);

            resultado.Direccion = l.Direccion;
            resultado.Email = l.Email;
            resultado.Estado = l.Estado;
            resultado.Nombre = l.Nombre;
            resultado.Telefono = l.Telefono;
            context.SaveChanges();
        }
    }
}
