using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOfStudents
{
    internal class Program
    {
        static void Main()
        {
            
            BadStudent b = new BadStudent();

            b.Name = "Vlad";
            //Console.WriteLine(b.ProspalParu("YES"));
            AvarageStudent av = new AvarageStudent();
            b.Print();

            av.PassTheExam("No");
        }
    }
}
