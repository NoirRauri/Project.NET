using DLL.Interfaz;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class ClientesDL : IGenericDL<tbClientes>
    {
        public bool eliminar(tbClientes entity)
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
            catch (Exception)
            {

                throw;
            }
        }

        public tbClientes guardar(tbClientes entity)
        {
            try
            {
                using (var context = new dbProyectoINAEntities1())
                {
                    context.tbClientes.Add(entity);
                    context.SaveChanges();
                    return entity;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool modificar(tbClientes entity)
        {
            try
            {
                using (var context = new dbProyectoINAEntities1())
                {
                    context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                    context.Entry(entity.tbPersona).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<tbClientes> obtenerTodos()
        {
            try
            {
                using (var context = new dbProyectoINAEntities1())
                {
                    return context.tbClientes.Include("tbPersona").Where(x=>x.estado==true).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public tbClientes obtenerPorID(tbClientes entidad)
        {
            try
            {
                using (var context = new dbProyectoINAEntities1())
                {
                    return context.tbClientes.Where(x => x.cedula.Trim() == entidad.cedula.Trim()).SingleOrDefault();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       
    }
}
