using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    internal class Lobo : Canino
    {
        public Lobo()
        {
        }

        public Lobo(string foto, string comida, string localizacion, int tamano) : base(foto, comida, localizacion, tamano)
        {
        }

        public override void comer()
        {
            base.comer();
        }

        public override void hacarRuido()
        {
            base.hacarRuido();
        }
    }
}
