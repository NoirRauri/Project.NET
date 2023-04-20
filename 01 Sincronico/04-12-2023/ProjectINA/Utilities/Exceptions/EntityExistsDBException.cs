using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Exceptions
{
    internal class EntityExistsDBException : Exception
    {
        public EntityExistsDBException(string nombreEntidad) : 
            base(string.Format("Ya existe {0} en la base de datos",nombreEntidad))
        {
        }
    }
}
