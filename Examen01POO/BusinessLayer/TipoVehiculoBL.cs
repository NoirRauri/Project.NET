using BusinessLayer.Interface;
using DataLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TipoVehiculoBL : IAutomovilBL<tbTipoVehiculo>
    {
        TipoVehiculoDL ItipoVehiculoDL = new TipoVehiculoDL();
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
            return ItipoVehiculoDL.obtenerPorID(entity);
        }

        public List<tbTipoVehiculo> obtenerTodos()
        {
            return ItipoVehiculoDL.obtenerTodos();
        }
    }
}
