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
    public class MarcaBL : IAutomovilBL<tbMarca>
    {
        MarcaDL ImarcaDL = new MarcaDL();
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
            return ImarcaDL.obtenerPorID(entity);
        }

        public List<tbMarca> obtenerTodos()
        {
            return ImarcaDL.obtenerTodos();
        }
    }
}
