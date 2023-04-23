using BL.Interfaces;
using DLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class RolesBl : IGenericBL<tbRoles>
    {
        RolesDL rolesIns = new RolesDL();
        public bool eliminar(tbRoles entity)
        {
            throw new NotImplementedException();
        }

        public tbRoles guardar(tbRoles entity)
        {
            throw new NotImplementedException();
        }

        public bool modificar(tbRoles entity)
        {
            throw new NotImplementedException();
        }

        public tbRoles obtenerPorID(tbRoles entidad)
        {
            throw new NotImplementedException();
        }

        public List<tbRoles> obtenerTodos()
        {
            return rolesIns.obtenerTodos();

        }
    }
}
