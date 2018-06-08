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
        public void ReplaceUniversity(int index, University university)
        {
            universitiesList.RemoveAt(index);
            universitiesList.Insert(index, university);
        }

        public string[] GetUniversityArray(int index)
        {
            University university = universitiesList[index];
            List<string> val = new List<string>();
            val.Add(university.code);
            val.Add(university.country);
            val.Add(university.site);
            val.Add(university.faculty);
            return val.ToArray();
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
