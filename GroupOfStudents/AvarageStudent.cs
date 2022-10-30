using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOfStudents
{
    internal class AvarageStudent : Student
    {

        public bool PassTheExam(string pass)
        {        
            if (pass == "YES" ||pass == "yes"|| pass == "DA" || pass == "da")
            {
                Console.WriteLine("Congratulations!");
                Console.WriteLine("Rating has been added");
                AddHometaskRate(10);
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, you didn't pass the exam");
                return false;
            }
            
                     
        }
        public AvarageStudent() : base()
        {

        }

        public override void Print()
        {
            base.Print();
        }
    }
}
