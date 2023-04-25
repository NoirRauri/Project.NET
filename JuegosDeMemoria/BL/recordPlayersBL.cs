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
    public class recordPlayersBL : IGenericBL<tbRecordPlayers>
    {
        recordPlayersDL recordPlayerIns=new recordPlayersDL();
        public bool eliminar(tbRecordPlayers entity)
        {
            throw new NotImplementedException();
        }

        public tbRecordPlayers guardar(tbRecordPlayers entity)
        {
            return recordPlayerIns.guardar(entity);
        }

        public bool modificar(tbRecordPlayers entity)
        {
            throw new NotImplementedException();
        }

        public tbRecordPlayers obtenerPorID(tbRecordPlayers entidad)
        {
            return recordPlayerIns.obtenerPorID(entidad);
        }

        public List<tbRecordPlayers> obtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
