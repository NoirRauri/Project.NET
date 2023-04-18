using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClase01
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // // comentario
            // int num=0,n2=0,n3=0;
            // var num2=0;
            // bool bandera = false;
            
            // float bandera2 = 0;
            // string cadena = null;
            // double num3 = 0;

            // object dato = null;

            // Array array = null;
            int[] vector=new int[5];
            int[,] matriz = new int[5,4]; 

            List<int> list = new List<int>();
            
        }

        //public static void calcular()
        //{

        //}
    }
}
