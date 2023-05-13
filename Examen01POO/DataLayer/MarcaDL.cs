using DataLayer.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MarcaDL : IAutomavilDL<tbMarca>
    {
        public bool eliminar(tbMarca entity)
        {
            throw new NotImplementedException();
        }

        public tbMarca guardar(tbMarca entity)
        {
            throw new NotImplementedException();
        }

        public bool modificar(tbMarca entity)
        {
            throw new NotImplementedException();
        }

        public tbMarca obtenerPorID(tbMarca entity)
        {
            try
            {
                using (var context = new dbExamen1POOEntities())
                {
                    return context.tbMarca.Where(x => x.id == entity.id).SingleOrDefault();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<tbMarca> obtenerTodos()
        {
            try
            {
                using (var context = new dbExamen1POOEntities())
                {
                    return context.tbMarca.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
