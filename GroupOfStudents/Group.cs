using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupOfStudents;

namespace GroupOfStudents
{
    internal class Group
    {
        LinkedList<Student> students = new LinkedList<Student>();
        string nameGroup = "bu111";
        string nameSpecalizationGroup = "programmer";
        int numberSemester = 2;

        static string[] names = { "Rodion", "Vladyslav", "Konstatyn", "Vytaliy", "Yuriy", "Nikolay", "Ekateryna", "Alyona", "Daria", "Aleksandra", "Anastasia", "Svetlana" };
        static string[] surnames = { "Shevchenko", "Vasilenko", "Ovcharenko", "Borisenko", "Tkachenko", "Fedorenko", "Jakovenko", "Pavlenko", "Ivashenko", "Sklyarenko", "Kravchenko", "Ponomarenko" };

        static Random random = new Random();



        public Group()
        {

            for (int i = 0; i < 11; i++)
            {
                Student s = new Student();
                s.SetName(names[random.Next(0, 12)]);
                s.SetSurname(surnames[random.Next(0, 12)]);
                s.SetAge(random.Next(16, 50));
                // s.SetExam();
                students.AddLast(s);
            }
        }

        public Group(int x)
        {

        }

        public Group(Group g)
        {
            //countStudents = g.GetCountStudents();
            //this.students = g.students;
            //this.nameGroup = g.nameGroup;
            //this.nameSpecalizationGroup = g.nameSpecalizationGroup;
            //this.numberSemester = g.numberSemester;
        }

        public void SetNameGroup(string nameGroup)
        {
            this.nameGroup = nameGroup;
        }

        public void SetNameSpecalizationGroup(string nameSpecalizationGroup)
        {
            this.nameSpecalizationGroup = nameSpecalizationGroup;
        }

        public void SetNumberSemester(int numberSemester)
        {
            this.numberSemester = numberSemester;
        }

        public int GetCountStudents()
        {
            return students.Count;
        }

        public string GetNameGroup()
        {
            return nameGroup;
        }

        public string GetNameSpecalizationGroup()
        {
            return nameSpecalizationGroup;
        }

        public int GetNumberSemester()
        {
            return numberSemester;
        }


        public void AddStudent(Student s)
        {
            students.AddLast(s);
        }


        public void TransfereStudent(int index, Group destination)
        {
            if (index < 0 || index >= students.Count) return;

            Student s = students.ElementAt(index);
            destination.AddStudent(s);
            students.Remove(s);
        }

        public Student EliminationStudent()
        {
            // делаем предположение, что у первого поавшегося студента группы - минимальнй средний балл
            double min_average = students.ElementAt(0).GetAverageRate();
            int current_index = 0; // на каком номере студента из группы мы находимся сейчас (перебор начинается с начала группы)
            Student bad = students.ElementAt(0); // ссылка на студента у которого средний балл - минимальный
            foreach (var student in students)
            {
                double current_avg = student.GetAverageRate();
                if (current_avg < min_average)
                {
                    min_average = current_avg;
                    bad = student;
                }
                current_index++;
            }

            students.Remove(bad);
            return bad;
        }

        public void UnsuccessfulStudent()
        {
            //int x = 12;
            //int y = 0;
            //int[] arrStud = new int[countStudents];
            //for (int i = 0; i < arrStud.Length; i++)
            //{
            //    //for (int j = 0; j < (students[0] as Student).dzArr.Length; j++)
            //    //{
            //    //    arrStud[i] += (students[0] as Student).dzArr[j];
            //    //}
            //    //arrStud[i] /= (students[0] as Student).dzArr.Length;
            //}
            //for (int i = 0; i < arrStud.Length; i++)
            //{
            //    if (arrStud[i] < x)
            //    {
            //        x = arrStud[i];
            //        y = i;
            //    }
            //}
            //students.RemoveAt(y);
        }

        public void Print()
        {
            Console.WriteLine("Name group: " + nameGroup);
            Console.WriteLine("Specialization group: " + nameSpecalizationGroup);
            int number = 1;
            foreach (var item in students)
            {
                Console.WriteLine("Student # " + number + ": ");
                item.ShowRates();
                Console.WriteLine("AVG RATE: " + item.GetAverageRate() + "\n");
                number++;
            }

        }

        public void PrintRaitings()
        {

        }

    }

}

