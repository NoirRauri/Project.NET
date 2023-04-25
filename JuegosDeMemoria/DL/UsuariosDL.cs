using DL.Interfaz;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class UsuariosDL : IGenericDL<tbUsuarios>
    {
        public bool eliminar(tbUsuarios entity)
        {
            throw new NotImplementedException();
        }

        public tbUsuarios guardar(tbUsuarios entity)
        {
            try
            {
                using (var context = new MemoryGameEntities())
                {
                    context.tbUsuarios.Add(entity);
                    context.SaveChanges();
                    return entity;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool modificar(tbUsuarios entity)
        {
            throw new NotImplementedException();
        }

        public tbUsuarios obtenerPorID(tbUsuarios entidad)
        {
            try
            {
                using (var context = new MemoryGameEntities())
                {
                    return context.tbUsuarios.Where(x => x.usuario == entidad.usuario && x.password == entidad.password).SingleOrDefault();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tbUsuarios> obtenerTodos()
        {
            try
            {
                using (var context = new MemoryGameEntities())
                {
                    return context.tbUsuarios.Include("tbJugadores").ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
