using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasic
{
    internal class Conditionals
    {
       
        public static void PosOrNeg()
        {
            var num =0;
            Console.WriteLine("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            if(num > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if(num < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

        }
    }
}
