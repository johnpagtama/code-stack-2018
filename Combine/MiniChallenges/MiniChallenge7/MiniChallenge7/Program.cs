using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniChallenge7
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums;

            Console.WriteLine("Enter a number: ");
            //int num = 12;
            //Console.WriteLine(num.ToString().Reverse().ToArray());
            //char[] newnums = nums[0].ToCharArray();
            //IEnumerable<string> newnums = nums.Select(a => a);
            
            foreach (int b in nums)
            {
                Console.WriteLine(b.ToString().Reverse().ToArray());
            }

            //Console.WriteLine(new char[] { nums[0].ToCharArray()[0], nums[0].ToCharArray()[1] });

            //Reverse array

            //Display original array

            //Display reversed array
        }
    }
}
