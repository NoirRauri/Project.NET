using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    internal interface IAutomovilBL<entity>
    {
        entity guardar(entity entity);
        bool modificar(entity entity);
        bool eliminar(entity entity);
        entity obtenerPorID(entity entity);
        List<entity> obtenerTodos();
    }
}
