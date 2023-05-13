using DataLayer.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TipoVehiculoDL : IAutomavilDL<tbTipoVehiculo>
    {
        public bool eliminar(tbTipoVehiculo entity)
        {
            throw new NotImplementedException();
        }

        public tbTipoVehiculo guardar(tbTipoVehiculo entity)
        {
            throw new NotImplementedException();
        }

        public bool modificar(tbTipoVehiculo entity)
        {
            throw new NotImplementedException();
        }

        public tbTipoVehiculo obtenerPorID(tbTipoVehiculo entity)
        {
            try
            {
                using (var context = new dbExamen1POOEntities())
                {
                    return context.tbTipoVehiculo.Where(x => x.id == entity.id).SingleOrDefault();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<tbTipoVehiculo> obtenerTodos()
        {
            try
            {
                using (var context = new dbExamen1POOEntities())
                {
                    return context.tbTipoVehiculo.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
