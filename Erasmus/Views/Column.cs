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

        public bool IsStudents{ get; set; }

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
            get {return null; }                
            set
            {
                ClearColumns();
                try
                {
                    if (IsStudents)
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
                    else if (!IsStudents)
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
                catch(Exception) { }
            }
                

        }     


           
        private void ClearColumns()
        {
            listBoxValues1.Items.Clear();
            listBoxValues2.Items.Clear();
            listBoxValues3.Items.Clear();
            listBoxValues4.Items.Clear();
        }
    }
}
