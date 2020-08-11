using System;

namespace MiniChallenge6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number: ");

            int num = Convert.ToInt32(Console.ReadLine());

            string isOdd = (num % 2 == 0 ? "is Even" : "is Odd");

            Console.WriteLine($"{num} {isOdd}");
        }
    }
}