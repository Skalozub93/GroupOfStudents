using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOfStudents
{
    internal class BadStudent : Student
    {

        
        public bool ProspalParu(string trues)
        {
            if (trues == "YES" ||trues == "yes"|| trues == "DA" || trues == "da")
            {
                AddHometaskRate(2);
            }
            else return false;
            return true;
        }

        public BadStudent() : base()
        { }

        public override void Print()
        {  
            base.Print();
        }
    }

}
