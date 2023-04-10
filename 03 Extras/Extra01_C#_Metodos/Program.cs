namespace Extra01_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            mensaje();
            sumarNumeros(7, 8);
            Console.WriteLine($"la resta de los numeros es de {restaNumeros(18, 7)}");
            Console.WriteLine($"la divición de los numeros es de {divicionNumeros(18, 7)}");
            Console.WriteLine($"la multiplicaion de los numeros es de: {multiplicacioNumeros(10, 10, 10)}");
        }

        // impresión
        static void mensaje()
        {
            Console.WriteLine("Nuevo, Mensaje!");
        }

        // sin retorno
        static void sumarNumeros(int num1, int num2)
        {
            Console.WriteLine($"La suma del numero {num1} + {num2} es {num1 + num2}");
        }

        // con retorno
        static int restaNumeros(int num1, int num2)
        {
            return num1 / num2;
        }

        // modularización
        static double divicionNumeros(double num1, int num2) => num1 / num2;

        /*
          Sobrecarga de metodos: 
          cuando se crean varios métodos con el mismo nombre en una clase, 
          pero con diferentes parámetros.
        */
        static int multiplicacioNumeros(int num1, int num2) => num1 * num2;
        static double multiplicacioNumeros(double num1, int num2) => num1 * num2;
        static double multiplicacioNumeros(double num1, int num2, int num3) => num1 * num2 * num3;

    }
}