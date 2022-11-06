using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GroupOfStudents
{
    class EventProspal
    {
        public string OverSlept
        {
            get;
            set;
        }

        public EventProspal(string word)
        {
            this.OverSlept = word;
        }

        public string WhyWasAbsent()
        {
            Console.WriteLine(OverSlept);
            return OverSlept;
        }
    }

    class EventAvtomat
    {
        public int RateOfExam 
        {
            get;
            set; 
        }

        public EventAvtomat(int rateOfExam)
        {
            RateOfExam = rateOfExam;
        }

        public int GetAvtomat()
        {
            return RateOfExam;
        }
    }

    /// <summary>
    /// Класс Студент
    /// </summary>
    internal class Student : Person, ICloneable, IComparable<Student> 
    {
        /// <summary>
        /// Лист домашних заданий
        /// </summary>
        private SortedSet<int> hometasks = new SortedSet<int>();
        /// <summary>
        /// Лист экзаменов
        /// </summary>
        private SortedSet<int> exams = new SortedSet<int>();
 

        static Random random = new Random();
        
        public delegate void HandlerAvtomat(Student s, EventAvtomat eV);
        public delegate void HandlerProspal(Student s, EventProspal eP);

        public event HandlerAvtomat avtomat;
        public event HandlerProspal prospal;

        /// <summary>
        /// Сравнение студентов по оценкам за домашнее задание 
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


        /// <summary>
        /// Сравнение студентов по имени
        /// </summary>
        public class CompareStudentByName : IComparer<Student>
        {
            public int Compare(Student a, Student b)
            {
                return a.Name.CompareTo(b.Name);
            }
        }


        /// <summary>
        /// Сравнение студентов по фамилии
        /// </summary>
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
                hometasks.Add(random.Next(1, 13));
            }
        }
        /// <summary>
        /// Конструктор копирования 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="lastname"></param>
        /// <param name="age"></param>
        public Student(string name, string surname, string lastname, int age) : base(name, surname, lastname, age) { }

        /// <summary>
        /// конструктор копирования с ссылкой на базовый тип
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="lastname"></param>
        /// <param name="age"></param>
        /// <param name="adress"></param>
        /// <param name="phoneNumber"></param>
        public Student(string name, string surname, string lastname, int age, string adress, int phoneNumber) : base(name, surname, lastname, age, adress, phoneNumber) { }

        /// <summary>
        /// Конструктор копирования со всеми параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="lastname"></param>
        /// <param name="age"></param>
        /// <param name="adress"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="hometasks"></param>
        /// <param name="exams"></param>
        public Student(string name, string surname, string lastname, int age, string adress, int phoneNumber, SortedSet<int> hometasks, SortedSet<int> exams)
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

        /// <summary>
        /// Оператор сравнения, сравнивает обьекты
        /// </summary>
        /// <param name="ob1"></param>
        /// <param name="ob2"></param>
        /// <returns></returns>
        public static bool operator ==(Student ob1, Student ob2)
        {
            if (ob1.GetAverageRate() == ob2.GetAverageRate() && ob1.Name == ob2.Name)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Оператор сравнения, сравнивает обьекты
        /// </summary>
        /// <param name="ob3"></param>
        /// <param name="ob4"></param>
        /// <returns></returns>
        public static bool operator !=(Student ob3, Student ob4)
        {
            if (ob3.GetAverageRate()!=ob4.GetAverageRate())
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Оператор сравнения, сравнивает обьекты
        /// </summary>
        /// <param name="obj1"></param>
        /// <param name="obj2"></param>
        /// <returns></returns>
        public static bool operator >(Student obj1, Student obj2)
        {
            if (obj1.GetAverageRate() > obj2.GetAverageRate())
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Оператор сравнения, сравнивает обьекты
        /// </summary>
        /// <param name="obj1"></param>
        /// <param name="obj2"></param>
        /// <returns></returns>
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
                    hometasks.Add(rate);
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
                    hometasks.Add(rate);
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

        /// <summary>
        /// Распечатка информации
        /// </summary>
        public override void Print()
        {
            base.Print();
        }
    }
}

