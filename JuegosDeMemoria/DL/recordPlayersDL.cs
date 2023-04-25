using DL.Interfaz;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class recordPlayersDL : IGenericDL<tbRecordPlayers>
    {
        public bool eliminar(tbRecordPlayers entity)
        {
            throw new NotImplementedException();
        }

        public tbRecordPlayers guardar(tbRecordPlayers entity)
        {
            try
            {
                using (var context = new MemoryGameEntities())
                {
                    context.tbRecordPlayers.Add(entity);
                    context.SaveChanges();
                    return entity;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool modificar(tbRecordPlayers entity)
        {
            throw new NotImplementedException();
        }

        public tbRecordPlayers obtenerPorID(tbRecordPlayers entidad)
        {
            throw new NotImplementedException();
        }

        public List<tbRecordPlayers> obtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
