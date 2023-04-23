using BL.Interfaces;
using DLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class TipoClientesBL : IGenericBL<tbTipoClientes>
    {
        //instancia ppara comunicarme con la capade dl
        TipoClientesDL tipoClienteIns = new TipoClientesDL();

        public bool eliminar(tbTipoClientes entity)
        {
            throw new NotImplementedException();
        }

        public tbTipoClientes guardar(tbTipoClientes entity)
        {
            //Reglas de negocio
            throw new NotImplementedException();

            //guardar DL
        }

        public bool modificar(tbTipoClientes entity)
        {
            throw new NotImplementedException();
        }

        public tbTipoClientes obtenerPorID(tbTipoClientes entidad)
        {
            throw new NotImplementedException();
        }

        public List<tbTipoClientes> obtenerTodos()
        {//no hay reglas  de negocio
            //retorna la lista que  devuelva la  capa de datos DL
            return tipoClienteIns.obtenerTodos();
        }
    }
}
