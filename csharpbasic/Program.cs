using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Enter your Age: ");
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine("How are you" + name);
            Console.WriteLine("You are " + age + " years old.");
        }
    }
}
