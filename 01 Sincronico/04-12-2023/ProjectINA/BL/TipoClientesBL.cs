using BL.Interfaces;
using DL;
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
        // instacia comunica con la capa de DL
        TipoClientesDL tipoClientesIns = new TipoClientesDL();
        public bool eliminar(tbTipoClientes entity)
        {
            throw new NotImplementedException();
        }

        public tbTipoClientes guardar(tbTipoClientes entity)
        {
            throw new NotImplementedException();
        }

        public bool modificar(tbTipoClientes entity)
        {
            throw new NotImplementedException();
        }

        public tbTipoClientes obtenerPorId(tbTipoClientes entity)
        {
            throw new NotImplementedException();
        }

        public List<tbTipoClientes> obtenerTodos()
        {
            return tipoClientesIns.obtenerTodos();
        }
    }
}
