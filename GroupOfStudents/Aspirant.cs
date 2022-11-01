using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOfStudents
{
    /// <summary>
    /// Класс Аспирант
    /// </summary>
    internal class Aspirant : Student
    {
        public string scientificTheme;

        /// <summary>
        /// Свойство записи научной темы
        /// </summary>
        public string Theme
        {
            get { return scientificTheme; }
            set { scientificTheme = value; }
        }
        /// <summary>
        /// Конструктор копирования без параметров с ссылкой на базовый тип
        /// </summary>
        public Aspirant() : base()
        {
            scientificTheme = "Сайт о паттернах проектирования";
        }
        /// <summary>
        /// Конструктор копирования 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="lastname"></param>
        /// <param name="age"></param>
        /// <param name="scientificTheme"></param>
        public Aspirant(string name, string surname, string lastname, int age, string scientificTheme ) : base(name, surname, lastname, age)
        {
            this.scientificTheme = scientificTheme;
        }

        /// <summary>
        /// Конструктор копирования со всеми параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="lastname"></param>
        /// <param name="age"></param>
        /// <param name="adress"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="scientificTheme"></param>
        public Aspirant(string name, string surname, string lastname, int age, string adress, int phoneNumber,string scientificTheme) : base(name, surname, lastname, age, adress, phoneNumber)
        {
            this.scientificTheme = scientificTheme;
        }

        /// <summary>
        /// Вывод информации
        /// </summary>
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Тема научной работы: " + scientificTheme);
        }

    }
}
