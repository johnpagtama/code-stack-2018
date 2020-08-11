using System;

namespace MiniChallenge5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool selection;
            int value;
            string user;

            Console.WriteLine("Enter 1 to select Steve\nEnter 2 to select Julia\nEnter 3 to select Lucy\nEnter 4 to select Ben");

            selection = int.TryParse(Console.ReadLine(), out value);

            while (value <= 0 || value > 4 || !selection)
            {
                Console.WriteLine("Invalid entry");
                selection = int.TryParse(Console.ReadLine(), out value);
            } 

            user = value == 1 ? "Steve" : value == 2 ? "Julia" : value == 3 ? "Lucy" : "Ben";

            Console.WriteLine($"Hello {user}");
        }
    }
}