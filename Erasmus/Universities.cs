using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Erasmus
{
    [XmlRoot("Universities")]
    public class Universities
    {
        [XmlElement("University")]
        public List<University> universitiesList;


        Universities()
        {
            universitiesList = new List<University>();
        }


        public University[] ToArray() => universitiesList.ToArray();

    }

    public class University
    {
        [XmlElement("Code")]
        public string code;
        [XmlElement("Country")]
        public string country;
        [XmlElement("Site")]
        public string site;
        [XmlElement("Faculty")]
        public string faculty;

        public University()
        {
            this.code = "";
            this.country = "";
            this.site = "";
            this.faculty = "";
        }
        
    }
}
