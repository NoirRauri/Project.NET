using DLL.Interfaz;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class RolesDL : IGenericDL<tbRoles>
    {
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
            try
            {
                using (var context = new dbProyectoINAEntities1())
                {
                    return context.tbRoles.Where(x => x.estado == true).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;


            }
        }
    }
}
