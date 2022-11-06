using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GroupOfStudents
{
    /// <summary>
    /// Класс Персона
    /// </summary>
    internal class Person
    {
        /// <summary>
        /// Поле хранения имени о персоне
        /// </summary>
        private string name;
        /// <summary>
        /// Поле хранения фамилии о персоне
        /// </summary>
        private string surname;
        /// <summary>
        /// Поле хранения отчества о персоне
        /// </summary>
        private string lastname;
        /// <summary>
        /// Поле хранения возраста о персоне
        /// </summary>
        private int age;
        /// <summary>
        /// Поле хранения адресса персоны
        /// </summary>
        private string adress;
        /// <summary>
        /// Поле хранения номера телефона персоны
        /// </summary>
        private int phoneNumber;

        /// <summary>
        /// Конструктор копирования без параметров
        /// </summary>
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
        public Person(string name, string surname, string lastname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.lastname = lastname;
            this.age = age;
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
        public Person(string name, string surname, string lastname, int age, string adress, int phoneNumber)
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

        /// <summary>
        /// Запись Отчества персоны
        /// </summary>
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        /// <summary>
        /// Запись возраста персоны
        /// </summary>
        public int Age
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

        /// <summary>
        /// Вывод информации о персоне
        /// </summary>
        public virtual void Print()
        {
           
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("SurName : " + Surname);
            Console.WriteLine("LastName : " + Lastname);
            Console.WriteLine("Date of Birthday : " + Age);
            Console.WriteLine("Home Address : " + Adress);
            Console.WriteLine("Phone of Number : " + PhoneNumber);
            
        }
    }
}

