using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    internal class Perro:Canino
    {
        public Perro() { }

        public Perro(string foto, string comida, string localizacion, int tamano) : base(foto, comida, localizacion, tamano)
        {
        }

        public override void hacarRuido()
        {
            base.hacarRuido();
        }

        public override void comer()
        {
            base.comer();
        }

        public void vacunar()
        {

        }

        public void sacarPasear()
        {

        }


    }
}
