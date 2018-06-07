using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erasmus
{
    public partial class View : Form, IView
    {
        public View()
        {
            InitializeComponent();
        }

        Universities universitiesList = null;
        Students studentsList = null;


        public event Func <bool, object> FillWithXML;
        private void studenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            columns.TypeOfData = "Students";
            columns.ColName = new string[] { "Imię", "Nazwisko", "email", "Uczelnia" };
            if (studentsList == null)
                studentsList = (Students)FillWithXML(true); //true - get students
            columns.ColElements = studentsList;
            

        }

        private void uczelnieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            columns.TypeOfData = "Universities";
            columns.ColName = new string[] { "Kod Erasmus", "Pańswto", "Strona WWW", "Wydział" };
            if (universitiesList == null)
                universitiesList = (Universities)FillWithXML(false); //false - get universities           
            columns.ColElements = universitiesList;
            


        }
    }
}
