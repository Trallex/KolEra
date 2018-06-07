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

    }
}
