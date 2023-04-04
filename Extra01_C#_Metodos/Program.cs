namespace Extra01_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            mensaje();
            sumarNumeros(7, 8);
        }

        static void mensaje()
        {
            Console.WriteLine("Nuevo, Mensaje!");
        }

        static void sumarNumeros(int num1, int num2)
        {
            Console.WriteLine($"La suma del numero {num1} + {num2} es {num1 + num2}");
        }
    }
}