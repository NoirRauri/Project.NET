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
    public class ClientesBL : IGenericBL<tbClientes>
    {

        ClientesDL clientesIns = new ClientesDL();
        public bool eliminar(tbClientes entity)
        {
            throw new NotImplementedException();
        }

        public tbClientes guardar(tbClientes entity)
        {
            throw new NotImplementedException();
        }

        public bool modificar(tbClientes entity)
        {
            throw new NotImplementedException();
        }

        public tbClientes obtenerPorId(tbClientes entity)
        {
            throw new NotImplementedException();
        }

        public List<tbClientes> obtenerTodos()
        {

            return clientesIns.obtenerTodos();
            
        }
    }
}
