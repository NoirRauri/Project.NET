using BL.Interfaces;
using DLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Excepciones;

namespace BL
{
    public class ClientesBL : IGenericBL<tbClientes>
    {
        //para acceder a la capa ClienteDL
        ClientesDL clientesIns = new ClientesDL();
        public bool eliminar(tbClientes entity)
        {
            return clientesIns.eliminar(entity);
        }

        public tbClientes guardar(tbClientes entity)
        {
            //reglas de negocio

            //ver si existe ya el cliente
            var cliente= obtenerPorID(entity);
            if (cliente != null)
            {
                //error
                throw new EntityExistDBException("Clientes");
            }

            // guardar al dl
            return clientesIns.guardar(entity);
        }

        public bool modificar(tbClientes entity)
        {
            return clientesIns.modificar(entity);
        }

        public List<tbClientes> obtenerTodos()
        {
            return clientesIns.obtenerTodos();
        }


        public tbClientes obtenerPorID(tbClientes entidad)
        {
            return clientesIns.obtenerPorID(entidad);
        }
    }
}
