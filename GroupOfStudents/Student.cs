using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOfStudents
{
    internal class Student
    {
        // <summary>
        // приватные методы класса о студенте
        // </summary>
        private string name;
        private int age;
        private string surname;

        private DateTime dateBirthday;

        private string adress;
        private int phoneNumber;
        private bool exam;

        // <summary>
        // двусвязный список оценок студента
        // </summary>
        private LinkedList<int> hometasks = new LinkedList<int>();

        static Random random = new Random();

        // <summary>
        // конструктор копирования
        // </summary>
        public Student()
        {
            int rates_count = random.Next(15, 30);
            for (int i = 0; i < rates_count; i++)
            {
                hometasks.AddLast(random.Next(1, 13));
            }
        }
        // <summary>
        // конструктор копирования
        // </summary>
        public Student(string surname, string name, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        // <summary>
        // Запись имени студента
        // </summary>
        public void SetName(string name)
        {
            this.name = name;
        }

        // <summary>
        // Получение имени студента
        // </summary>
        public string GetName()
        {
            return this.name;
        }

        // <summary>
        // Запись фамилии студента
        // </summary>
        public void SetSurname(string surname)
        {
          this.surname = surname;
        }

        // <summary>
        // Получение фамилии студента
        // </summary>
        public string GetSurname()
        {
            return this.surname;
        }

        // <summary>
        // Запись возраста студента
        // </summary>
        public void SetAge(int age)
        {
            this.age = age;
        }

        // <summary>
        // Получение возраста студента
        // </summary>
        public int GetAge()
        {
            return this.age;
        }

        // <summary>
        // Запись адресса студента
        // </summary>
        public void SetAdress(string adress)
        {
            this.adress = adress;
        }

        // <summary>
        // Получение адресса студента
        // </summary>
        public string GetAdress()
        {
            return this.adress;
        }

        // <summary>
        // Запись номера телефона студента
        // </summary>
        public void SetPhoneNumber(int phoneNumber)
        {
           this.phoneNumber = phoneNumber;
        }


        // <summary>
        // Получение номера телефона студента
        // </summary>
        public int GetPhoneNumber()
        {
            return this.phoneNumber;
        }

        // <summary>
        // Свойство Записи экзамена студента
        // </summary>
        public void SetExam()
        {
            if (random.Next(0, 2) == 0)
                exam = false;
            else exam = true;
        }

        // <summary>
        // Информация об оценках
        // </summary>
        public double GetAverageRate()
        {
            double result = 0;
            foreach (var item in hometasks)
            {
                result += item;
            }
            return result / hometasks.Count;
        }

        // <summary>
        // Показ рейтинга студента
        // </summary>
        public void ShowRates()
        {
            foreach (var item in hometasks)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }

        // <summary>
        // Добавление оценки за домашнее задание
        // </summary>
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
            catch(Exception ex)
                {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

