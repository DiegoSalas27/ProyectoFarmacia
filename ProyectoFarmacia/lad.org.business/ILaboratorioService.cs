﻿using lad.org.entities2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lad.org.business
{
    public interface ILaboratorioService : IService<Laboratorio>
    {
        Laboratorio ReadByIdLaboratorio(int id);
        Laboratorio ReadByNombreLaboratorio(string nombre);
        bool ReadByDireccion(string direccion, int telefono, string email, string nombre);
    }
}
