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
            get
            {
                if (listViewData.Items != null)
                {
                    int i = listViewData.SelectedItems[0].Index;
                    return i;
                }
                else return 0;
            }// listBoxValues1.SelectedIndex; }
                set
            {
                if(value >-1)
                {
                    listViewData.Items[value].Selected = true;
                    listViewData.Select();
                }
                
            }
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
                    foreach (string s in listViewData.Items)
                    {
                        Console.WriteLine(s);
                        //Student student = new Student(s, listBoxValues2.Items[i].ToString(), listBoxValues3.Items[i].ToString(), listBoxValues4.Items[i].ToString());
                      //  i++;
                       // students.Add(student);
                    }
                    return students;
                }
                else if(TypeOfData == "Universities")
                {
                    List<University> universities = new List<University>();
                    foreach (string s in listViewData.Items)
                    {
                       // University university = new University(s, listBoxValues2.Items[i].ToString(), listBoxValues3.Items[i].ToString(), listBoxValues4.Items[i].ToString());
                        //i++;
                       // universities.Add(university);
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

                            ListViewItem item = new ListViewItem(s.name);
                            item.SubItems.Add(s.surname);
                            item.SubItems.Add(s.email);
                            item.SubItems.Add(s.code);
                            listViewData.Items.Add(item);
                        }
                    }
                    else if (TypeOfData=="Universities")
                    {
                        Universities universities = (Universities)value;
                        foreach (University u in universities.universitiesList)
                        {
                            ListViewItem item = new ListViewItem(u.code);
                            item.SubItems.Add(u.country);
                            item.SubItems.Add(u.site);
                            item.SubItems.Add(u.faculty);
                            listViewData.Items.Add(item);
                        }
                    }               
            }
                

        }     

           
        private void ClearColumns()
        {
            listViewData.Items.Clear();

        }


        private void ItemSelect(object sender, EventArgs e)
        {
                //object t = ColElements;

        }
    }
}
