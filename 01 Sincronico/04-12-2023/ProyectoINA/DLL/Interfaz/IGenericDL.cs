using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Interfaz
{
    internal interface IGenericDL<entidad>
    {
        entidad guardar(entidad entity);
        bool modificar(entidad entity);
        bool eliminar(entidad entity);
        entidad obtenerPorID(entidad entidad);
        List<entidad> obtenerTodos();

    }
}
