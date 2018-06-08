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

        public Universities universitiesList
        {
            get { return universitiesList; }
            set { universitiesList = value; }
        }
        public Students studentsList
        {
            get { return studentsList; }
            set { studentsList = value; }
        }
        public string DataType
        {
            get { return columns.TypeOfData; }
            set { columns.TypeOfData = value; }
        }
        public object ColumnsValue
        {
            get { return columns.ColElements; }
            set { columns.ColElements = value; }
        }
        public string[] ColumsLabels
        {
            get { return columns.ColName; }
            set { columns.ColName = value; }
        }

        
        private void studenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataType = "Students";
            setColumnsAndLabels();

        }

        private void uczelnieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataType = "Universities";
            setColumnsAndLabels();
            //columns.ColName = 
        }


        public event Func<string, object> LoadData;
        public event Func<string, string[]> GetLables;
        private void setColumnsAndLabels()
        {
            ColumnsValue = LoadData(DataType);
            ColumsLabels = GetLables(DataType);
        }













        public event Func<bool, object> FillWithXML;

    }
}
