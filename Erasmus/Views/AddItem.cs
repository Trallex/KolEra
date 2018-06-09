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
    public partial class AddItem : Form, IAddItem
    {
        public AddItem(string[] labels)
        {
            InitializeComponent();
            fillFields(labels);
        }

        public event Action<string[]> AddNewObject;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (AllFilled())
                AddNewObject(GenerateObject());
            else
                errorProvider1.SetError(buttonAdd, "Uzupełnij wszystkie dane!");
        }
        private string[] GenerateObject()
        {
            List<string> vs = new List<string>();
            vs.Add(textBoxValue1.Text);
            vs.Add(textBoxValue2.Text);
            vs.Add(textBoxValue3.Text);
            vs.Add(textBoxValue4.Text);
            return vs.ToArray();
        }

        private bool AllFilled()
        {
            if (textBoxValue1.Text != "" && textBoxValue2.Text != "" && textBoxValue3.Text != "" && textBoxValue4.Text != "")
                return true;
            else return false;
        }
        private void fillFields(string[] labels)
        {
            label1.Text = labels[0];
            label2.Text = labels[1];
            label3.Text = labels[2];
            label4.Text = labels[3];
        }
    }
}
