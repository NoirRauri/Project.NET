using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IGenericBL<entidad>
    {
        entidad guardar(entidad entity);
        bool modificar(entidad entity); 
        bool eliminar(entidad entity);
        entidad obtenerPorId(entidad entity);
        List<entidad> obtenerTodos();


    }
}
