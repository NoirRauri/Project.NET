using DL.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class ClientesDL : IGenericDL<tbClientes>
    {
        public bool eliminar(tbClientes entity)
        {
            try
            {
                using (var context = new dbProyectoINAEntities())
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

        public tbClientes guardar(tbClientes entity)
        {
            try
            {
                using (var context = new dbProyectoINAEntities())
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
                using (var context = new dbProyectoINAEntities())
                {

                    context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public tbClientes obtenerPorId(tbClientes entity)
        {
            try
            {
                using (var context = new dbProyectoINAEntities())
                {
                  return  context.tbClientes.Where(x => x.cedula.Trim() == entity.cedula.Trim()).SingleOrDefault();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tbClientes> obtenerTodos()
        {
            try
            {
                using (var context = new dbProyectoINAEntities())
                {
                    return context.tbClientes.Include("tbPersona").ToList();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}