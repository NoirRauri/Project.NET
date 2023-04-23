
using BL.Interfaces;
using DLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Excepciones;

namespace BL
{
    public class UsuariosBL : IGenericBL<tbUsuarios>
    {
        UsuariosDL usuarioIns = new UsuariosDL();
        public bool eliminar(tbUsuarios entity)
        {
            throw new NotImplementedException();
        }

        public tbUsuarios guardar(tbUsuarios entity)
        {

            //reglas de negocio

            //ver si existe ya el usuario
            var user = obtenerPorID(entity);
            if (user != null)
            {
                //error
                throw new EntityExistDBException("Clientes");
            }

            // guardar al dl
            return usuarioIns.guardar(entity);
        }

        public bool modificar(tbUsuarios entity)
        {
            throw new NotImplementedException();
        }

        public tbUsuarios obtenerPorID(tbUsuarios entidad)
        {
            throw new NotImplementedException();
        }

        public List<tbUsuarios> obtenerTodos()
        {
            return usuarioIns.obtenerTodos();
        }
    }
}
