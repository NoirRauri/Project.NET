using DataLayer.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AutomovilDL : IAutomavilDL<tbAutomovil>
    {
        public bool eliminar(tbAutomovil entity)
        {
            try
            {
                using (var context = new dbExamen1POOEntities())
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

        public tbAutomovil guardar(tbAutomovil entity)
        {
            try
            {
                using (var context = new dbExamen1POOEntities())
                {
                    context.tbAutomovil.Add(entity);
                    context.SaveChanges();
                    return entity;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool modificar(tbAutomovil entity)
        {
            try
            {
                using (var context = new dbExamen1POOEntities())
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

        public tbAutomovil obtenerPorID(tbAutomovil entity)
        {
            try
            {
                using (var context = new dbExamen1POOEntities())
                {
                    return context.tbAutomovil.Where(x => x.placa == entity.placa && x.estado==true).SingleOrDefault();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<tbAutomovil> obtenerTodos()
        {
            try
            {
                using (var context = new dbExamen1POOEntities())
                {
                    return context.tbAutomovil.Where(x => x.estado == true).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
