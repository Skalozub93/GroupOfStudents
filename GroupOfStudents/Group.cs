using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupOfStudents;


namespace GroupOfStudents
{
    // <summary>
    // группа студентов представлена типом List 
    // </summary>
    internal class Group : Student,ICloneable,IComparable<Group>
    {
        LinkedList<Student> students = new LinkedList<Student>();
        string nameGroup = "bu111";
        string nameSpecalizationGroup = "programmer";
        int numberSemester = 2;
        static Random random = new Random();

        

        public int CompareTo(Group anotherGroup)
        {
            if (this.nameGroup == anotherGroup.nameGroup)
                return 1;
            else
                return -1;

        }

        public class CompareGroupBySpecalization : IComparer<Group>
        {
            public  int Compare(Group a, Group b)
            {
                return a.nameSpecalizationGroup.CompareTo(b.nameSpecalizationGroup);
            }   
        }

        public class CompareGroupBySemestr : IComparer<Group>
        {

            public int Compare(Group a, Group b)
            {
                return a.NumberSemester.CompareTo(b.NumberSemester);
            }
        }
       
        public Group NotDeepClones()
        {
            return (Group)this.MemberwiseClone();
        }

        public object Cloneable()
        {
            return new Group(this.students, this.nameGroup, this.nameSpecalizationGroup, this.numberSemester);
        }

        public Group(LinkedList<Student> students, string nameGroup, string nameSpecalizationGroup, int numberSemester)
        {
            this.students = students;
            this.nameGroup = nameGroup;
            this.nameSpecalizationGroup = nameSpecalizationGroup;
            this.numberSemester = numberSemester;
            
        }


        public static bool operator ==(Group obj1, Group obj2)
        {
            if(obj1.students.Count == obj2.students.Count)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Group obj1, Group obj2)
        {
            return !(obj1 == obj2);
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
        /// Конструктор копирования. Создаёт группу, точную копию другой группы.
        /// </summary>
        public Group(Group g)
        {
            //countStudents = g.GetCountStudents();
            //this.students = g.students;
            //this.nameGroup = g.nameGroup;
            //this.nameSpecalizationGroup = g.nameSpecalizationGroup;
            //this.numberSemester = g.numberSemester;
        }

        /// <summary>
        /// Свойство Названия Групы.
        /// </summary>
        public string NameOfGroup   
        {
            get { return nameGroup; }
            set { NameOfGroup = value; }
           
        }

        /// <summary>
        /// Свойство Названия Специализации.
        /// </summary>
        public string NameSpecalizationGroup
        {
            get { return NameSpecalizationGroup; }
            set { NameSpecalizationGroup = value; }
        }

        /// <summary>
        /// Свойство Номера семестра.
        /// </summary>
        public int NumberSemester
        {
            get { return numberSemester;}
            set { numberSemester = value; }
        }

        /// <summary>
        /// Свойство Количества студентов.
        /// </summary>
        public int CountStudents
        {
            get { return CountStudents; }
            set { CountStudents = value; }
        }

        /// <summary>
        /// Свойство Номера семестра.
        /// </summary>
        public int NumberOfSemester
        {
            get { return numberSemester; }
            set { numberSemester = value; }
        }

        /// <summary>
        /// Добавления Студента в группу
        /// </summary>
        public void AddStudent(Student s)
        {
            students.AddLast(s);
        }

        /// <summary>
        /// Перевод студента в другую группу
        /// </summary>
        public void TransfereStudent(int index, Group destination)
        {
            if (index < 0 || index >= students.Count) return;

            Student s = students.ElementAt(index);
            destination.AddStudent(s);
            students.Remove(s);
        }

        /// <summary>
        /// Удаления студента из группы
        /// </summary>
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

        /// <summary>
        /// Вывод полной информации о группе и студенте
        /// </summary>
        public override void Print()
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
    }
}

