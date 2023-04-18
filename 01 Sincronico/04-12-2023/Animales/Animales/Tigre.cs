using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    internal class Tigre : Felino
    {
        public Tigre()
        {
        }

        public Tigre(string foto, string comida, string localizacion, int tamano) : base(foto, comida, localizacion, tamano)
        {
        }

        public override void hacarRuido()
        {
            Console.WriteLine("estoy haciendo ruido como Tigre");
            //base.hacarRuido();
        }

        public override void dormir()
        {
            Console.WriteLine("estoy cominedo como Tigre");
            //base.dormir();
        }
    }
}
