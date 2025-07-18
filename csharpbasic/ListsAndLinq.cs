using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasic
{
    internal class ListsAndLinq
    {
        public void Run()
        {
            List<int> ints = new List<int>() {};
            Console.WriteLine("Enter 5 integers: ");
            for (int i = 0; i < 5; i++)
            {
                ints.Add(int.Parse(Console.ReadLine()));
            }
            // Fix: Use a different variable name in the lambda to avoid shadowing 'ints'
            var squaredEvens = ints.Where(x => x % 2 == 0).Select(x => x * x);
            Console.WriteLine("Squared even numbers:");
            foreach (var num in squaredEvens)
            {
                Console.WriteLine(num);
            }
        }

    }

}

    