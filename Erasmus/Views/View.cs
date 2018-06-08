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

        #region pblc vals
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
        #endregion


        public event Func<string, object> LoadData;
        public event Func<string, string[]> GetLables;
        public event Func<int, string[]> GetObjectValues;
       


        #region mds
        private void studenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataType = "Students";
            setColumnsAndLabels();

        }

        private void uczelnieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataType = "Universities";
            setColumnsAndLabels();            
        }


        
        private void setColumnsAndLabels()
        {
            ColumnsValue = LoadData(DataType);
            ColumsLabels = GetLables(DataType);
        }





        #endregion

        private void buttonShowRecord_Click(object sender, EventArgs e)
        {
           
            if (columns.SelectedIndex != -1)
            {
                Views.EditItem editItem = new Views.EditItem(GetLables(DataType), GetObjectValues(columns.SelectedIndex), columns.SelectedIndex);
                //editItem.Parent = this;
                editItem.ShowDialog();
            }

        }
    }
}
