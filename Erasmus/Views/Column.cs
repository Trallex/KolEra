using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erasmus.Views
{
    public partial class Column : UserControl
    {
        public Column()
        {
            InitializeComponent();
        }
      
        public string TypeOfData { get; set; }
        public int SelectedIndex
        {
            get { return listBoxValues1.SelectedIndex; }
            set { listBoxValues1.SelectedIndex = value; }
        }
        public string[] ColName
        {
            get
            {
                List<string> temp = new List<string>();
                temp.Add(labelColName1.Text);
                temp.Add(labelColName2.Text);
                temp.Add(labelColName3.Text);
                temp.Add(labelColName4.Text);
                return temp.ToArray();
            }

            set
            {
                labelColName1.Text = value[0];
                labelColName2.Text = value[1];
                labelColName3.Text = value[2];
                labelColName4.Text = value[3];
            }
        }

        public object ColElements
        {
            get
            {                
                int i = 0;
                if (TypeOfData == "Students")
                {
                    List<Student> students = new List<Student>();
                    foreach (string s in listBoxValues1.Items)
                    {
                        Student student = new Student(s, listBoxValues2.Items[i].ToString(), listBoxValues3.Items[i].ToString(), listBoxValues4.Items[i].ToString());

                    }
                    return students;
                }
                else if(TypeOfData == "Universities")
                {
                    List<University> universities = new List<University>();
                    foreach (string s in listBoxValues1.Items)
                    {
                        University university = new University(s, listBoxValues2.Items[i].ToString(), listBoxValues3.Items[i].ToString(), listBoxValues4.Items[i].ToString());
                        i++;
                        universities.Add(university);
                    }
                    return universities;
                }
                return null;
            }                
            set
            {
                ClearColumns();

                    if (TypeOfData=="Students")
                    {
                        Students students = (Students)value;
                        foreach (Student s in students.studentList)
                        {
                            listBoxValues1.Items.Add(s.name);
                            listBoxValues2.Items.Add(s.surname);
                            listBoxValues3.Items.Add(s.email);
                            listBoxValues4.Items.Add(s.code);
                        }
                    }
                    else if (TypeOfData=="Universities")
                    {
                        Universities universities = (Universities)value;
                        foreach (University u in universities.universitiesList)
                        {
                            listBoxValues1.Items.Add(u.code);
                            listBoxValues2.Items.Add(u.country);
                            listBoxValues3.Items.Add(u.site);
                            listBoxValues4.Items.Add(u.faculty);
                        }
                    }               
            }
                

        }     

           
        private void ClearColumns()
        {
            listBoxValues1.Items.Clear();
            listBoxValues2.Items.Clear();
            listBoxValues3.Items.Clear();
            listBoxValues4.Items.Clear();
        }

        private void IndexChange(object sender, EventArgs e)       
        {
            ListBox lb = sender as ListBox;
            listBoxValues1.SelectedIndex = lb.SelectedIndex;
            listBoxValues2.SelectedIndex = lb.SelectedIndex;
            listBoxValues3.SelectedIndex = lb.SelectedIndex;
            listBoxValues4.SelectedIndex = lb.SelectedIndex;
        }

        private void ItemSelect(object sender, EventArgs e)
        {
                //object t = ColElements;

        }
    }
}
