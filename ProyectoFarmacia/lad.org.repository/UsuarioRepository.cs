using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lad.org.entities2;

namespace lad.org.repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        dbFarmaciaEntities context = null;

        public UsuarioRepository()
        {
            context = new dbFarmaciaEntities();
        }

        public usuario ObtenerUsarioPorCorreo(string correo)
        {
            return context.usuario.FirstOrDefault(x => x.correo == correo);
        }
        public usuario ObtenerUsarioPorClave(string clave)
        {
            return context.usuario.FirstOrDefault(x => x.password == clave);
        }
    }
}
