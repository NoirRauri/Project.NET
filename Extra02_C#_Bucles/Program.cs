internal class Program
{
    private static Random rNum = new Random();

    private static void Main(string[] args)
    {
        int num = randomNum();
        int resp = 0;

        System.Console.WriteLine("Adivina el numero entre 0 a 100");

        while (resp != num)
        {
            resp = int.Parse(Console.ReadLine());

            if (resp > num) System.Console.WriteLine("El numero es menor");
            else if (resp < num) System.Console.WriteLine("El numero debe es mayor");
        }

        System.Console.WriteLine($"Felicidades adivinaste el numero {num}");

        static int randomNum() => rNum.Next(0, 100);

    }

}