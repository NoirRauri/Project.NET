using BL.Interfaces;
using DL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Exceptions;

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
            //reglas de negocio

            //validar si existe el cliente
            var cliente = obtenerPorId(entity);
            if (cliente != null)
            {
                // error
                throw new EntityExistsDBException("Clientes");
            }

            // guardar DL
            return clientesIns.guardar(entity);
        }

        public bool modificar(tbClientes entity)
        {
            throw new NotImplementedException();
        }

        public tbClientes obtenerPorId(tbClientes entity)
        {
            return clientesIns.obtenerPorId(entity);
        }

        public List<tbClientes> obtenerTodos()
        {

            return clientesIns.obtenerTodos();
            
        }
    }
}
