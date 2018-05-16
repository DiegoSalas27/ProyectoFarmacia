using lad.org.entities2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lad.org.repository
{
    public interface ILaboratorioRepository : IRepositorio<Laboratorio>
    {
        Laboratorio ReadByIdLaboratorio(int id);
        Laboratorio ReadByNombreLaboratorio(string nombre);
        bool ReadByDireccion(string direccion, int telefono, string email, string nombre);
    }
}
