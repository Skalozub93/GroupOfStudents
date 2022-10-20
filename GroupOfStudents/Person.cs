using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GroupOfStudents
{
    internal class Person
    {
        /// <summary>
        /// приватные методы класса о студенте
        /// </summary>
        private string name;
        private string surname;
        private string lastname;
        private DateTime age;


        private string adress;
        private int phoneNumber;

        public Person()
        {

        }

        /// <summary>
        /// Конструктор имени, фамилии, отчества и возраста о персоне
        /// </summary> 
        /// <param name="name">Имя студента</param>
        /// <param name="surname">Фамилия студента</param>
        /// <param name="lastname">Отчество студента</param>
        /// <param name="age">Возраст студента</param>
        public Person(string name, string surname, string lastname, DateTime age)
        {
            this.name = name;
            this.surname = surname;
            this.lastname = lastname;
            this.age = age;
        }


        // <summary>
        /// Конструктор со всеми параметрами
        /// </summary>
        /// <param name="name">Имя студента</param>
        /// <param name="surname">Фамилия студента</param>
        /// <param name="lastname">Отчество студента</param>
        /// <param name="age">Возраст студента</param>
        /// <param name="adress">Адресс студента</param>
        /// <param name="phoneNumber">Номер телефона студента</param>
        public Person(string name, string surname, string lastname, DateTime age, string adress, int phoneNumber)
        {
            this.name = name;
            this.surname = surname;
            this.lastname = lastname;
            this.age = age;
            this.adress = adress;
            this.phoneNumber = phoneNumber;
        }
        /// <summary>
        /// Запись имени персоны
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        /// <summary>
        /// Запись фамилии персоны
        /// </summary>
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public DateTime Age
        {
            get { return age; }
            set { age = value; }

        }

        /// <summary>
        /// Запись адресса с
        /// </summary>
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        /// <summary>
        /// Запись номера телефона 
        /// </summary>
        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public virtual void Print()
        {       
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("SurName : " + Surname);
            Console.WriteLine("LastName : " + Lastname);
            Console.WriteLine("Date of Birthday : " + Age);
            Console.WriteLine("Home Address : " + Adress);
            Console.WriteLine("Phone Number : " + PhoneNumber);
        }
    }
}

