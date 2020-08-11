using System;

namespace MiniChallenge4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string isGreaterOrLess;

            Console.WriteLine("Enter 2 numbers: ");

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            isGreaterOrLess = num1 > num2 ? $"{num1} > {num2}" : $"{num1} < {num2}";

            Console.WriteLine($"{isGreaterOrLess}");
        }
    }
}
