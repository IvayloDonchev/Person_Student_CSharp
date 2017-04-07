using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Ivaylo Donchev", 1971);
            Console.WriteLine(p);

            Student s = new Student("Petar Petrov", 1990, "18012", "Informatics", 4);
            s.AddResult("Object oriented programming", 6.0);
            s.AddResult("Web development", 5.0);
            Console.WriteLine(s);

            Console.WriteLine($"{s.Name} results");
            s.ShowResults();
            Console.ReadKey();
        }
    }
}
