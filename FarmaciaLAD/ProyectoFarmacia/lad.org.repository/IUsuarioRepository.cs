using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lad.org.entities2;

namespace lad.org.repository
{
    public interface IUsuarioRepository
    {
        usuario ObtenerUsarioPorClave(string clave);
        usuario ObtenerUsarioPorCorreo(string correo);
    }
}
