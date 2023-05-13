using DataLayer.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ColorDL : IAutomavilDL<tbColor>
    {
        public bool eliminar(tbColor entity)
        {
            throw new NotImplementedException();
        }

        public tbColor guardar(tbColor entity)
        {
            throw new NotImplementedException();
        }

        public bool modificar(tbColor entity)
        {
            throw new NotImplementedException();
        }

        public tbColor obtenerPorID(tbColor entity)
        {
            try
            {
                using (var context = new dbExamen1POOEntities())
                {
                    return context.tbColor.Where(x => x.id== entity.id).SingleOrDefault();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<tbColor> obtenerTodos()
        {
            try
            {
                using (var context = new dbExamen1POOEntities())
                {
                    return context.tbColor.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
