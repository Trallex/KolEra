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

        public string ColName
        {
            get { return labelColName.Text; }
            set { labelColName.Text = value; }
        }

        public string[] ColElements
        {
            get
            {
                return listBoxValues.Items.OfType<string>().ToArray();
            }
            set
            {
                listBoxValues.Items.Clear();
                listBoxValues.Items.AddRange(value);
            }
        }
    }
}
