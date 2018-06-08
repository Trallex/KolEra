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
                return new string[] { "Kod Erasmus", "Pańswto", "Strona WWW", "Wydział" };
            }
            else if(set=="Students")
            {
                return new string[] { "Imię", "Nazwisko", "email", "Uczelnia" };
            }
            else return null;
        }
    }
}
 