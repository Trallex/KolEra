using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Erasmus
{
    [XmlRoot("Students")]
    public class Students
    {
        [XmlElement("Student")]
        public List<Student> studentList;


        Students()
        {
            studentList = new List<Student>();
        }


        public Student[] ToArray() => studentList.ToArray();

        public void AddItem(Student s)
        {
            studentList.Add(s);
        }
        public void ReplaceStudent(int index, Student student)
        {
            studentList.RemoveAt(index);
            studentList.Insert(index, student);
        }
        public string[] GetStudentArray(int index)
        {
            Student student = studentList[index];
            List<string> val = new List<string>();
            val.Add(student.name);
            val.Add(student.surname);
            val.Add(student.email);
            val.Add(student.code);
            return val.ToArray();
        }

    }

    public class Student
    {
        [XmlElement("Name")]
        public string name;
        [XmlElement("Surname")]
        public string surname;
        [XmlElement("email")]
        public string email;
        [XmlElement("University")]
        public string code;


        public Student()
        {
            this.name = "";
            this.surname = "";
            this.email = "";
            this.code = "";

        }

        public Student(string name, string surname, string email, string code)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.code = code;

        }

    }
}
