using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOfStudents
{

    internal class Program
    {     

        delegate void MyDelegateGroup(Group name, int num);
    

        static void Main()
        {
            FileSaver fs = new FileSaver();
            Student s = new Student();

            fs.SaveStudentToFile(s);

            Group g = new Group();

         
           

            
            
             
            



        }       
    }
}





////Student student = new Student();
////SortedSet<Student> list = new SortedSet<Student>();


////Group g = new Group(list, "ПУ111", "Программисты", 3);
////Student a = new AvarageStudent();
////Student b = new BadStudent();
////Student c = new GoodStudent();
////Student d = new Student();
////Student e = new BadStudent();

////g.AddStudent(a);
////g.AddStudent(b);
////g.AddStudent(c);
////g.AddStudent(d);
////g.AddStudent(e);

////g.Print();
////Console.ReadLine();



//////void AvtomatExamRate(Student s, EventAvtomat eA)
//////{
//////    s.AddExamRate(eA.GetAvtomat());
//////}
//////void AvtomatExamsRateIfSleep(Student s, EventProspal eP)
//////{
//////    Console.WriteLine("Не было на паре потому что: " + eP.OverSlept);
//////}

////MyDelegateGroup MDG = AddStudentDelegate;

////while(true)
////{
////    Console.WriteLine("1 - добавить студента в группу");
////    Console.WriteLine("2 - удалить студента из группы");
////    Console.WriteLine("3 - посмотреть список студентов");
////    Console.WriteLine("0 - выход");


////    string key = Console.ReadLine(); 
////    if(key == "1")
////    {
////        MDG += AddStudentDelegate;
////        MDG -= RemoveStudentDelegate;
////        MDG -= ShowListStudentDelegate;
////        MDG -= ExitStudentDelegate;
////        MDG(g,1);
////    }
////    if(key == "2")
////    {
////        MDG -= AddStudentDelegate;
////        MDG += RemoveStudentDelegate;
////        MDG -= ShowListStudentDelegate;
////        MDG -= ExitStudentDelegate;
////        MDG(g, 1);
////    }
////    if(key == "3")
////    {
////        MDG -= AddStudentDelegate;
////        MDG -= RemoveStudentDelegate;
////        MDG += ShowListStudentDelegate;
////        MDG -= ExitStudentDelegate;
////        MDG(g, 1);
////    }
////    if(key == "0")
////    {
////        MDG -= AddStudentDelegate;
////        MDG -= RemoveStudentDelegate;
////        MDG -= ShowListStudentDelegate;
////        MDG += ExitStudentDelegate;
////        MDG(g, 1);
////    }
////}
////void AddStudentDelegate(Group name, int num)
////{
////    name.AddStudentOnValue(num);
////}
////void RemoveStudentDelegate(Group name, int num)
////{
////    name.RemoveStudentOnValue(num);
////}
////void ShowListStudentDelegate(Group name, int num)
////{
////    foreach (Student item in name)
////    {
////        item.Print();
////    }
////}
////void ExitStudentDelegate(Group name, int num)
////{
////    Environment.Exit(0);
////}
