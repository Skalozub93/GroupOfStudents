using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupOfStudents;


namespace GroupOfStudents
{
    /// <summary>
    /// Класс группа
    /// </summary>
    internal class Group : Student,ICloneable,IComparable<Group>
    {
        /// <summary>
        /// SortedSet студентов
        /// </summary>
        SortedSet<Student> students = new SortedSet<Student>();
        /// <summary>
        /// Название группы
        /// </summary>
        string nameGroup;
        /// <summary>
        /// Специализация группы
        /// </summary>
        string nameSpecalizationGroup;
        /// <summary>
        /// Номер семестра
        /// </summary>
        int numberSemester;

        static Random random = new Random();

        /// <summary>
        /// Реализация интерфейса Enumerator для "прохода" по коллекции
        /// </summary>
        /// <returns></returns>
        public MyEnumerator GetEnumerator()
        {
            return new MyEnumerator(students);
        }
        /// <summary>
        /// Сравнение групп по названию
        /// </summary>
        /// <param name="anotherGroup"></param>
        /// <returns></returns>
        public int CompareTo(Group anotherGroup)
        {
            if (this.nameGroup == anotherGroup.nameGroup)
                return 1;
            else
                return -1;

        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Group()
        {

        }
        /// <summary>
        /// Сравнение группы по названию специализации
        /// </summary>
        public class CompareGroupBySpecalization : IComparer<Group>
        {
            public  int Compare(Group a, Group b)
            {
                return a.nameSpecalizationGroup.CompareTo(b.nameSpecalizationGroup);
            }   
        }
        /// <summary>
        /// Сравнение группы по номеру семестра
        /// </summary>
        public class CompareGroupBySemestr : IComparer<Group>
        {

            public int Compare(Group a, Group b)
            {
                return a.NumberSemester.CompareTo(b.NumberSemester);
            }
        }
        /// <summary>
        /// Не глубокая копия группы
        /// </summary>
        /// <returns></returns>
        public Group NotDeepClones()
        {
            return (Group)this.MemberwiseClone();
        }

        /// <summary>
        /// Полная копия группы
        /// </summary>
        /// <returns></returns>
        public object Cloneable()
        {
            return new Group(this.students, this.nameGroup, this.nameSpecalizationGroup, this.numberSemester);
        }

  
        /// <summary>
        /// конструктор копирования 
        /// </summary>
        /// <param name="students"></param>
        /// <param name="nameGroup"></param>
        /// <param name="nameSpecalizationGroup"></param>
        /// <param name="numberSemester"></param>
        public Group(SortedSet<Student> students, string nameGroup, string nameSpecalizationGroup, int numberSemester)
        {
            this.students = students;
            this.nameGroup = nameGroup;
            this.nameSpecalizationGroup = nameSpecalizationGroup;
            this.numberSemester = numberSemester;
            
        }

        /// <summary>
        /// Оператор сравнения, сравнивает обьекты
        /// </summary>
        /// <param name="obj1"></param>
        /// <param name="obj2"></param>
        /// <returns></returns>
        public static bool operator ==(Group obj1, Group obj2)
        {
            if(obj1.students.Count == obj2.students.Count)
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
           students.Add(s);
        }

        /// <summary>
        ///  Добавление студента в группу по номеру
        /// </summary>
        /// <param name="add"></param>
        public void AddStudentOnValue(int add)
        {

            Student other = new Student();
            try
            {
                if (add == 1)
                {
                    students.Add(other);
                }
                else
                {
                    throw new Exception("Вы ввели некорректное значение!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ошибка: {ex.Message}");
            }
        }

        /// <summary>
        /// Удаление студента из группы по номеру
        /// </summary>
        /// <param name="rem"></param>
        public void RemoveStudentOnValue(int rem)
        {

            Student other = new Student();
            try
            {
                if (rem == 2)
                {
                    students.Remove(other);
                }
                else
                {
                    throw new Exception("Вы ввели некорректное значение!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ошибка: {ex.Message}");
            }
        }

        /// <summary>
        ///  Показ всех студентов группы
        /// </summary>
        public void ShowListOfStudents()
        {
            foreach (var item in students)
            {
                AddStudentOnValue(1);
                Console.WriteLine(item.Name);
            }
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

