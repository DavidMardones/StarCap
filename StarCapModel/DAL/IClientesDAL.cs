﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel.DAL
{
    public interface IClientesDAL
    {
        List<Cliente> Obtener();
        void Agregar(Cliente cliente);

        //Esto eliminara en la BD, por lo cual recibe el rut 
        void Eliminar(string rut);
    }
}
