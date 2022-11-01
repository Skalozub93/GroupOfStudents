using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOfStudents
{
    /// <summary>
    ///  Класс Плохой Студент
    /// </summary>
    internal class BadStudent : Student
    {

        /// <summary>
        /// Метод "Проспал пару"
        /// </summary>
        /// <param name="trues"></param>
        /// <returns></returns>
        public bool ProspalParu(string trues)
        {
            if (trues == "YES" ||trues == "yes"|| trues == "DA" || trues == "da")
            {
                AddHometaskRate(2);
            }
            else return false;
            return true;
        }

        /// <summary>
        /// Конструктор копирования с ссылкой на базовый тип
        /// </summary>
        public BadStudent() : base()
        { }
        /// <summary>
        /// Вывод информации
        /// </summary>
        public override void Print()
        {  
            base.Print();
        }
    }

}
