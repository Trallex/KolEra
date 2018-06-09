using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erasmus
{
    public class Model
    {
        internal Universities universitiesList;
        internal Students studentList;
        internal Universities GetUniversities(string path)
        {
            universitiesList = LoadXML.LoadUniversities(path);
            return universitiesList;
        }
        internal Students GetStudents(string path)
        {
            studentList = LoadXML.LoadStudents(path);
            return studentList;
        }

        internal string[] RetrunLables(string set)
        {
            if(set=="Universities")
            {
                return new string[] { "Kod Erasmus:", "Pańswto:", "Strona WWW:", "Wydział:" };
            }
            else if(set=="Students")
            {
                return new string[] { "Imię:", "Nazwisko:", "email:", "Uczelnia:" };
            }
            else return null;
        }

        internal string[] ObjectValue(int index, string type)
        {
            if(type=="Students")
            {
                return studentList.GetStudentArray(index);
               
            }
            else if(type=="Universities")
            {
                return universitiesList.GetUniversityArray(index);
            }
            else return null;
        }

        internal void IfChangesThenSave(int index, string[] objectArray, string dataType)
        {
            if(studentList.GetStudentArray(index)!=objectArray)
            {
                if(dataType=="Students")
                {
                    Student student = new Student(objectArray[0], objectArray[1], objectArray[2], objectArray[3]);
                    studentList.ReplaceStudent(index, student);
                }
                else if(dataType=="Universities")
                {
                    University university = new University(objectArray[0], objectArray[1], objectArray[2], objectArray[3]);
                    universitiesList.ReplaceUniversity(index, university);
                }
            }
        }

        internal void AddNewObject(string[] objectArray, string dataType)
        {
            if (dataType == "Students")
            {
                Student student = new Student(objectArray[0], objectArray[1], objectArray[2], objectArray[3]);
                studentList.AddItem(student);
            }
            else if (dataType == "Universities")
            {
                University university = new University(objectArray[0], objectArray[1], objectArray[2], objectArray[3]);
                universitiesList.AddItem(university);
            }
        }

        internal void SaveStudentsAndUniversities()
        {
            if (studentList != null) 
            {
                SaveXML.SaveToXML(studentList, "./DBStu.xml");
            }
            if (universitiesList != null) 
            {
                SaveXML.SaveToXML(universitiesList, "./DBUni.xml");
            }
        }

        internal void DeleteRecord(int index, string dataType)
        {
            if (dataType == "Students")
            {
                studentList.studentList.RemoveAt(index);
            }
            else if (dataType == "Universities")
            {
                universitiesList.universitiesList.RemoveAt(index);
            }
        }
    }
}
 