using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Student
{
    public class Student : Person
    {
        public string Faknum { get; private set; }
        public string Programme { get; private set; }
        public int Semester { get; private set; }
        public Student(string name, int year, string faknum, string programme, int semester) :
            base(name, year)
        {
            Faknum = faknum;
            Programme = programme;
            Semester = semester;
            results = new List<Result>();
        }
        private struct Result
        {
            public string subject;
            public double grade;
        }
        private List<Result> results;
        public double Rating => (results.Count > 0) ? results.Average(r => r.grade) : 0;
        public void AddResult(string s, double g) => results.Add(new Result {subject = s, grade = g});
        public override string ToString() => $"{Faknum} {base.ToString()}\n{Programme}\nSemester: {Semester}\nAverage grade: {Rating}";
        public void ShowResults()
        {
            Console.WriteLine("Results");
            foreach(var r in results)
                Console.WriteLine($"{r.subject}\t{r.grade}");
            Console.WriteLine($"Average: {Rating}");
        }
    }
}
