using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOfStudents
{
    internal class Student
    {
        private string name;
        private int age;
        private string surname;

        private DateTime dateBirthday;

        private string address;
        private int phoneNumber;
        private bool exam;

        // двусвязный список оценок студента
        private LinkedList<int> hometasks = new LinkedList<int>();

        static Random random = new Random();

        public Student()
        {


            int rates_count = random.Next(15, 30);
            for (int i = 0; i < rates_count; i++)
            {
                hometasks.AddLast(random.Next(1, 13));
            }

        }

        public Student(string surname, string name, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetSurname(string surname)
        {
            this.surname = surname;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }


        public void SetAdress(string adress)
        {
            this.address = adress;
        }

        public void SetPhoneNumber(int phonenumber)
        {
            this.phoneNumber = phonenumber;
        }

        public void SetExam()
        {
            if (random.Next(0, 2) == 0)
                exam = false;
            else exam = true;

        }


        public string GetName()
        {
            return name;
        }

        public string GetSurname()
        {
            return surname;
        }

        public int GetAge()
        {
            return age;
        }

        public string GetAdress()
        {
            return address;
        }

        public int GetPhoneNumber()
        {
            return phoneNumber;
        }

        public void ShowRates()
        {
            foreach (var item in hometasks)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }

        public double GetAverageRate()
        {
            double result = 0;
            foreach (var item in hometasks)
            {
                result += item;
            }
            return result / hometasks.Count;
        }

        public void AddHometaskRate(int rate)
        {
            if (rate >= 1 && rate <= 12)
            {
                hometasks.AddLast(rate);
            }
        }
    }
}

