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
    public class ColorBL : IAutomovilBL<tbColor>
    {
        ColorDL IcolorDL = new ColorDL();
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
            return IcolorDL.obtenerPorID(entity);
        }

        public List<tbColor> obtenerTodos()
        {
            return IcolorDL.obtenerTodos();
        }
    }
}
