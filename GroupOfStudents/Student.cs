using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GroupOfStudents
{

    internal class Student : Person, ICloneable, IComparable<Student> 
    {

        private LinkedList<int> hometasks = new LinkedList<int>();
        private LinkedList<int> exams = new LinkedList<int>();
 

        static Random random = new Random();

        /// <summary>
        /// Сравнение студентов по имени 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        
        public int CompareTo(Student other)
        {
            if(this.hometasks.Count > other.hometasks.Count)
                return 1;
            if (this.hometasks.Count < other.hometasks.Count)
                return -1;
            return 0;
        }

        public class CompareStudentByName : IComparer<Student>
        {
            public int Compare(Student a, Student b)
            {
                return a.Name.CompareTo(b.Name);
            }
        }
       
        public class CompareStudentBySurname : IComparer<Student>
        {
            public int Compare(Student a, Student b)
            {
                return a.Surname.CompareTo(b.Surname);
            }
        }


            /// <summary>
            /// Не глубокая копия
            /// </summary>
            /// <returns></returns>
            public Student NotDeepClone()
        {
            return (Student)this.MemberwiseClone();
        }

        /// <summary>
        /// Пользовательская копия
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Student(this.Name, this.Surname, this.Lastname, this.Age, this.Adress, this.PhoneNumber, this.hometasks, this.exams );
        }


        /// <summary>
        /// конструктор копирования
        /// </summary>
        public Student()
        {
            int rates_count = random.Next(15, 30);
            for (int i = 0; i < rates_count; i++)
            {
                hometasks.AddLast(random.Next(1, 13));
            }
        }

        public Student(string name, string surname, string lastname, int age) : base(name, surname, lastname, age) { }

        public Student(string name, string surname, string lastname, int age, string adress, int phoneNumber) : base(name, surname, lastname, age, adress, phoneNumber) { }

        public Student(string name, string surname, string lastname, int age, string adress, int phoneNumber, LinkedList<int> hometasks, LinkedList<int> exams)
        {
            this.Name = name;
            this.Surname = surname;
            this.Lastname = lastname;
            this.Age = age;
            this.Adress = adress;
            this.PhoneNumber = phoneNumber;
            this.hometasks = hometasks;
            this.exams = exams;

        }

        public static bool operator ==(Student ob1, Student ob2)
        {
            if (ob1.GetAverageRate() == ob2.GetAverageRate() && ob1.Name == ob2.Name)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Student ob3, Student ob4)
        {
            if (ob3.GetAverageRate()!=ob4.GetAverageRate())
            {
                return true;
            }
            return false;
        }

        public static bool operator >(Student obj1, Student obj2)
        {
            if (obj1.GetAverageRate() > obj2.GetAverageRate())
            {
                return true;
            }
            return false;
        }

        public static bool operator <(Student obj1, Student obj2)
        {
            if (obj1.GetAverageRate() < obj2.GetAverageRate())
            {
                return true;
            }
            return false;
        }

        public override bool Equals(object o)
        {
            return true;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        /// <summary>
        /// Свойство Записи экзамена студента
        /// </summary>
        public void AddExamRate(int rate)
        {
            try
            {

                if (rate >= 1 && rate <= 12)
                {
                    hometasks.AddLast(rate);
                }
                else
                {
                    throw new Exception("Оценка не может быть меньше одного или больше двенадцати!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SetHomeTask(bool hw)
        {
            if (random.Next(0, 2) == 0)
                hw = false;
            else hw= true;
        }

        /// <summary>
        /// Информация об оценках
        /// </summary>
        public double GetAverageRate()
        {
            double result = 0;
            foreach (var item in hometasks)
            {
                result += item;
            }
            return result / hometasks.Count;
        }

        /// <summary>
        /// Показ рейтинга студента
        /// </summary>
        public void ShowRates()
        {
            foreach (var item in hometasks)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Добавление оценки за домашнее задание
        /// </summary>
        public void AddHometaskRate(int rate)
        {
            try
            {

                if (rate >= 1 && rate <= 12)
                {
                    hometasks.AddLast(rate);
                }
                else
                {
                    throw new Exception("Оценка не может быть меньше одного или больше двенадцати!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Гендер
        /// </summary>
        public bool IsMale
        {
            get; set;
        }


        public override void Print()
        {
            base.Print();
        }
    }
}

