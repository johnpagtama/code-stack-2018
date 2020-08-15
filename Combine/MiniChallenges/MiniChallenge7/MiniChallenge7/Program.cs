using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniChallenge7
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = new List<int>();
            char anotherOne;
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Enter a number: ");

                nums.Add(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Would you like to enter another number?");

                anotherOne = Console.ReadLine()[0];

                Console.WriteLine("\n");

                loop = anotherOne.ToString().ToUpper() == 'Y'.ToString();
            }

            foreach (int num in nums)
            {
                Console.Write("Original values: ");
                Console.WriteLine(num);

                Console.Write("Reversed values: ");
                Console.WriteLine(num.ToString().Reverse().ToArray());
            }
        }
    }
}
