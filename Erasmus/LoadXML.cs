using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Erasmus
{
    public class LoadXML
    {

        public static Universities LoadUniversities(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Universities));
            FileStream fs = new FileStream(path, FileMode.Open);
            Universities result = (Universities)serializer.Deserialize(fs);
            fs.Close();
            return result;
        }

        public static Students LoadStudents(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Students));
            FileStream fs = new FileStream(path, FileMode.Open);
            Students result = (Students)serializer.Deserialize(fs);
            fs.Close();
            return result;
        }

    }
}
