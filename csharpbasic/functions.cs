using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasic
{
    internal class functions
    {
        public bool PrimeorNot()
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;
            for (int i=2; i<= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime) return true;
            else return false;


        }
    }
}
