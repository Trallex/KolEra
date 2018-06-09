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
        public event Action<string[], string[], int> OpenWindow;
        public event Action<object> FormClose;
        public event Action<int> DeleteRecord;

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

        private void buttonShowRecord_Click(object sender, EventArgs e)
        {
            if (columns.SelectedIndex != -1)
            {
                OpenWindow(GetLables(DataType), GetObjectValues(columns.SelectedIndex), columns.SelectedIndex);
                ColumnsValue = LoadData(DataType);
            }
        }

        private void View_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormClose(sender);
            
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            if (DataType == "Students" || DataType == "Universities")
            {
                OpenWindow(GetLables(DataType), null, 0);
                ColumnsValue = LoadData(DataType);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (columns.SelectedIndex != -1)
            {
                DeleteRecord(columns.SelectedIndex);
                ColumnsValue = LoadData(DataType);
            }
                
        }

        #endregion


    }
}
