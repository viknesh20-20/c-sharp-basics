using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasic
{
    internal class multiplicationtable
    {
        public static void multiplicationTable()
        {
            Console.WriteLine("Enter a number to generate its multiplication table: ");
            int number,len;
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the multiplication table: ");
            len = int.Parse(Console.ReadLine());
            for (int i = 1; i <= len; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }

        }
    }
}
