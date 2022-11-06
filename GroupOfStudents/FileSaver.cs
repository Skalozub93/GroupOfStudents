using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GroupOfStudents
{
    internal class FileSaver
    {
        public void SaveStudentToFile(Student other)
        {
            string saveStudent = JsonConvert.SerializeObject(other, Formatting.Indented);

            Student deserialized = JsonConvert.DeserializeObject<Student>(saveStudent);

            var sw = new StreamWriter(@"D:\vlad.txt");

            sw.Write(saveStudent);
            sw.Close();

            
        }

        public void SaveGroupToFile(Group other)
        {
            string saveGroup = JsonConvert.SerializeObject(other, Formatting.Indented);

            Student deserialized = JsonConvert.DeserializeObject<Student>(saveGroup);

            var sw = new StreamWriter(@"D:\vlad.txt");

            sw.Write(saveGroup);
            sw.Close();
        }
    }
}
