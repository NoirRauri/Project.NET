using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    internal class Leon : Felino
    {
        public Leon()
        {
        }

        public Leon(string foto, string comida, string localizacion, int tamano) : base(foto, comida, localizacion, tamano)
        {
        }

        public override void comer()
        {
            Console.WriteLine("estoy cominedo como León");
            //base.comer();
        }

        public override void hacarRuido()
        {
            Console.WriteLine("estoy haciendo ruido como León");
            //base.hacarRuido();
        }
    }
}
