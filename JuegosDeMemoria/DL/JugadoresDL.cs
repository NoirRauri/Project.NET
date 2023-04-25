using DL.Interfaz;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class JugadoresDL : IGenericDL<tbJugadores>
    {
        public bool eliminar(tbJugadores entity)
        {
            try
            {
                using (var context = new MemoryGameEntities())
                {
                    context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public tbJugadores guardar(tbJugadores entity)
        {
            try
            {
                using (var context = new MemoryGameEntities())
                {
                    context.tbJugadores.Add(entity);
                    context.SaveChanges();
                    return entity;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool modificar(tbJugadores entity)
        {
            throw new NotImplementedException();
        }

        public tbJugadores obtenerPorID(tbJugadores entidad)
        {
            try
            {
                using (var context = new MemoryGameEntities())
                {
                    return context.tbJugadores.Where(x => x.cedula == entidad.cedula).SingleOrDefault();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<tbJugadores> obtenerTodos()
        {
            try
            {
                using (var context = new MemoryGameEntities())
                {
                    return context.tbJugadores.Include("tbUsuarios").ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
