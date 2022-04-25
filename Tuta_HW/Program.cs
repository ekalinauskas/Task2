using System;

namespace Tuta_HW
{
    class First
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Labas, Pasauli!");
            Console.WriteLine("Enter first number:");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter second number:");
            string inputB = Console.ReadLine();

            int suma = int.Parse(inputA) + int.Parse(inputB);
            Console.WriteLine($"Suma: {suma}");
            Console.ReadLine();
        }
    }
}