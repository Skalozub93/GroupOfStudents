using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOfStudents
{
    /// <summary>
    /// Класс Хороший Студент
    /// </summary>
    internal class GoodStudent : Student
    {
        /// <summary>
        /// Конструктор копирования без параметров с ссылкой на базовый тип
        /// </summary>
        public GoodStudent() : base()
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
