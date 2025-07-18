using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasic
{
    internal class arrays
    {
        public static void MaxandMin()
        {
            int[] numbers = new int[5];
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter number " + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int max = numbers.Max();
            int min = numbers.Min();
            Console.WriteLine("The maximum number is: " + max);
            Console.WriteLine("The minimum number is: " + min);
        }
    }
}
