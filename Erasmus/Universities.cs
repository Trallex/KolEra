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
        public void EditElement(int i, University u)
        {
            universitiesList[i] = u;

        }

        public University[] ToArray() => universitiesList.ToArray();

        public void AddItem(University u)
        {
            universitiesList.Add(u);
        }

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
        public University(string code, string country, string site, string faculty)
        {
            this.code = code;
            this.country = country;
            this.site = site;
            this.faculty = faculty;
        }
    }
}
