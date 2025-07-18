using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasic
{
    internal class student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Grade { get; set; }
        public student(string name, int age, char grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");
        }
    }
}
