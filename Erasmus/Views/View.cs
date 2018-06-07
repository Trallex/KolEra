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
        public event Func <string[]> FillWithStudents;
        private void studenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            column1.ColName = "Imię";
            column2.ColName = "Nazwisko";
            column3.ColName = "email";
            column4.ColName = "Uczelnia";
        }

        private void uczelnieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            column1.ColName = "Kod Erasmus";
            column2.ColName = "Pańswto";
            column3.ColName = "Strona WWW";
            column4.ColName = "Wydział";
        }
    }
}
