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
    public class JugadoresBL : IGenericBL<tbJugadores>
    {
        JugadoresDL jugadoresIns =new JugadoresDL();
        public bool eliminar(tbJugadores entity)
        {
            throw new NotImplementedException();
        }

        public tbJugadores guardar(tbJugadores entity)
        {
            var cliente = obtenerPorID(entity);

            if (cliente != null)
            {
                throw new EntityExistDBException("Jugadores");
            }

            return jugadoresIns.guardar(entity);
        }

        public bool modificar(tbJugadores entity)
        {
            throw new NotImplementedException();
        }

        public tbJugadores obtenerPorID(tbJugadores entidad)
        {
            return jugadoresIns.obtenerPorID(entidad);
        }

        public List<tbJugadores> obtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
