using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    internal class Gato : Felino
    {
        public Gato()
        {
        }

        public Gato(string foto, string comida, string localizacion, int tamano) : base(foto, comida, localizacion, tamano)
        {
        }

        public override void hacarRuido()
        {
            Console.WriteLine("estoy haciendo ruido como Gato");
            base.hacarRuido();
        }

        public override void comer()
        {
            Console.WriteLine("estoy cominedo como gato");
            base.comer();
        }

        public void vacunar()
        {
            Console.WriteLine("vacuna para Gato");
        }
    }
}
