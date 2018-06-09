using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Erasmus
{
    public class SaveXML
    {
        public static void  SaveToXML(object obj, string filename)
            {
            XmlSerializer sr = new XmlSerializer(obj.GetType());
            StreamWriter writer = new StreamWriter(filename);
            sr.Serialize(writer, obj);
            writer.Close();
        }

    }
}
