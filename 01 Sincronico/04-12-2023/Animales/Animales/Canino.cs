using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    internal abstract class Canino : Animal
    {
        public Canino()
        {
        }

        public Canino(string foto, string comida, string localizacion, int tamano) : base(foto, comida, localizacion, tamano)
        {
        }

        public override void rugir()
        {
            Console.WriteLine("estoy rugiendo como canino");
        }
    }
}
