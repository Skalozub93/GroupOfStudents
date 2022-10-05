using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOfStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.ShowRates();
            Console.WriteLine(s.GetAverageRate());
            s.AddHometaskRate(12);
            s.ShowRates();
            Console.WriteLine(s.GetAverageRate());
        }
    }
}
