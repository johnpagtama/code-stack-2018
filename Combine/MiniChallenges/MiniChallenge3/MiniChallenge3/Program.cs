using System;

namespace MiniChallenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, time;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("What time did you wake up?");
            time = Console.ReadLine();

            Console.WriteLine($"{name} woke up at {time}");
        }
    }
}