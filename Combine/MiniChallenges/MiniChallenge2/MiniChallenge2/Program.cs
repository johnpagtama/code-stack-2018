using System;

namespace MiniChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Enter 2 numbers: ");

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = num1 + num2;

            Console.WriteLine($"{num1} plus {num2} equals {num3}");
        }
    }
}