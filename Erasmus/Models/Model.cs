using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erasmus
{
    public class Model
    {
        internal Universities GetUniversities(string path)
        {
            return LoadXML.LoadUniversities(path);
        }
        internal Students GetStudents(string path)
        {
            return LoadXML.LoadStudents(path);
        }
    }
}
 