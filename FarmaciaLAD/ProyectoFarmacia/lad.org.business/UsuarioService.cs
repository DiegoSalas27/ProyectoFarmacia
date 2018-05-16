using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lad.org.entities2;
using lad.org.repository;

namespace lad.org.business
{
    public class UsuarioService : IUsuarioService
    {
        IUsuarioRepository uRepo;

        public UsuarioService()
        {
            uRepo = new UsuarioRepository();
        }
        public usuario ObtenerUsarioPorClave(string clave)
        {
            return uRepo.ObtenerUsarioPorClave(clave);
        }

        public usuario ObtenerUsarioPorCorreo(string correo)
        {
            return uRepo.ObtenerUsarioPorCorreo(correo);
        }
    }
}
