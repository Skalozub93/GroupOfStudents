using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOfStudents
{
    /// <summary>
    /// Интерфейс "Перечеслитель"
    /// </summary>
    internal class MyEnumerator
    {   
        /// <summary>
        /// Поле с обобщённым типом студентов
        /// </summary>
        SortedSet<Student> massive;

        /// <summary>
        /// Конструктор копирования
        /// </summary>
        /// <param name="massive"></param>
        public MyEnumerator(SortedSet<Student> massive)
        {
            this.massive=massive;
        }

        /// <summary>
        /// Базовый метод Счётчик
        /// </summary>
        public object Current
        {
            get;
            set;
        }

        /// <summary>
        /// Поле индекс 
        /// </summary>
        int index;

        /// <summary>
        /// Метод для передвежения числителя
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            if(index >= massive.Count)
            {
                return false;
            }
            Current = massive.ElementAt<Student>(index++);
            return true;
        }
        /// <summary>
        /// Метод сброса
        /// </summary>
        public void Reset()
        {
            massive.Clear();
        }
    }
}
