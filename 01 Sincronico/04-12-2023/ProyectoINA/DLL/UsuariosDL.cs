using DLL.Interfaz;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class UsuariosDL : IGenericDL<tbUsuarios>
    {
        public bool eliminar(tbUsuarios entity)
        {
            try
            {
                using (var context = new dbProyectoINAEntities1())
                {
                    context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public tbUsuarios guardar(tbUsuarios entity)
        {
            try
            {
                using (var context = new dbProyectoINAEntities1())
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
            try
            {
                using (var context = new dbProyectoINAEntities1())
                {
                    context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw  ex;
            }
        }

        public tbUsuarios obtenerPorID(tbUsuarios entidad)
        {
            try
            {
                using (var context = new dbProyectoINAEntities1())
                {
                    return context.tbUsuarios.Where(x => x.cedula.Trim() == entidad.cedula.Trim()).SingleOrDefault();
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
                using (var context = new dbProyectoINAEntities1())
                {
                    return context.tbUsuarios.Include("tbRoles").Include("tbPersona").ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
