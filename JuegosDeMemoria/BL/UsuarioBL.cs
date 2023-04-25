using BL.Interfaz;
using DL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Excepsiones;

namespace BL
{
    public class UsuarioBL : IGenericBL<tbUsuarios>
    {
        UsuariosDL usuariosIns =new UsuariosDL();

        public bool eliminar(tbUsuarios entity)
        {
            throw new NotImplementedException();
        }

        public tbUsuarios guardar(tbUsuarios entity)
        {
            var cliente = obtenerPorID(entity);

            if (cliente != null)
            {
                throw new EntityExistDBException("Usuarios");
            }

            return usuariosIns.guardar(entity);
        }

        public bool modificar(tbUsuarios entity)
        {
            throw new NotImplementedException();
        }

        public tbUsuarios obtenerPorID(tbUsuarios entidad)
        {
            return usuariosIns.obtenerPorID(entidad);
        }

        public bool logearUsuario(tbUsuarios entity)
        {
            var cliente = obtenerPorID(entity);

            if (cliente == null)
            {
                throw new NotImplementedException();
            }

            return true;
        }

        public List<tbUsuarios> obtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
