using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erasmus.Views
{
    public partial class EditItem : Form, IEditItem
    {
        public event Action<int, string[]> SaveObject;

        public EditItem()
        {
            InitializeComponent(); 
        }

        public EditItem(string[] labels, string[] values, int index)
        {
            
            InitializeComponent();
            fillFields(labels, values);
            EditedItem = index;            

        }

        private int EditedItem;
        private string[]TextBoxObject
        {
            get
            {
                List<string> lis = new List<string>();
                lis.Add(textBoxValue1.Text);
                lis.Add(textBoxValue2.Text);
                lis.Add(textBoxValue3.Text);
                lis.Add(textBoxValue4.Text);
                return lis.ToArray();
            }
            set
            {
                textBoxValue1.Text = value[0];
                textBoxValue2.Text = value[1];
                textBoxValue3.Text = value[2];
                textBoxValue4.Text = value[3];
            }
        }

        





        private void buttonEdit_Click(object sender, EventArgs e)
        {
            textBoxValue1.Show();
            textBoxValue2.Show();
            textBoxValue3.Show();
            textBoxValue4.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {            
            SaveObject(EditedItem, TextBoxObject );
        }

        private void fillFields(string[] lables, string[]values)
        {
            labelType1.Text = lables[0];
            labelType2.Text = lables[1];
            labelType3.Text = lables[2];
            labelType4.Text = lables[3];

            labelValue1.Text = values[0];
            labelValue2.Text = values[1];
            labelValue3.Text = values[2];
            labelValue4.Text = values[3];

            TextBoxObject = values;
        }
    }
}
