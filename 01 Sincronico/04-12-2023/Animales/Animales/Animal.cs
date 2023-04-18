using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    internal abstract class Animal
    {
        public Animal() { }

        public Animal(string foto, string comida, string localizacion, int tamano)
        {
            this.foto = foto;
            this.comida = comida;
            this.localizacion = localizacion;
            this.tamano = tamano;
        }

        public string foto { get; set; }
        public string comida { get; set; }
        public string localizacion { get; set; }
        public int tamano { set; get; }

        public virtual void hacarRuido() {
            Console.WriteLine("estoy haciendo ruido");
        }

        public virtual void comer()
        {
            Console.WriteLine("estoy comiendo");
        }

        public virtual void dormir()
        {
            Console.WriteLine("estoy dormiendo");
        }

        public abstract void rugir();
            
    }
}
