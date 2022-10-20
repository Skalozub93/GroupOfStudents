using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOfStudents
{
    internal class Aspirant : Student
    {
        public string scientificTheme;

        public string Theme
        {
            get { return scientificTheme; }
            set { scientificTheme = value; }
        }

        public Aspirant() : base()
        {
            scientificTheme = "Сайт о паттернах проектирования";
        }

        public Aspirant(string name, string surname, string lastname, DateTime age, string scientificTheme ) : base(name, surname, lastname, age)
        {
            this.scientificTheme = scientificTheme;
        }

        public Aspirant(string name, string surname, string lastname, DateTime age, string adress, int phoneNumber,string scientificTheme) : base(name, surname, lastname, age, adress, phoneNumber)
        {
            this.scientificTheme = scientificTheme;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Тема научной работы: " + scientificTheme);
        }

    }
}
