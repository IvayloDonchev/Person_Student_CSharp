using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Student
{
    public class Person
    {
        public string Name { get; private set; }
        public int Year {get; private set; }
        public int Age { get => DateTime.Now.Year - this.Year; }
        public Person(string name, int year)
        {
            this.Name = name;
            this.Year = year;
        }
        public override string ToString() => $"{Name}, {Year} (Age {Age})";
       
    }
}
