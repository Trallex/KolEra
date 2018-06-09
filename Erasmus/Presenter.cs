using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erasmus
{
    public class Presenter
    {
        IView view;
        Model model;
        public Presenter(Model model, IView view, IEditItem editItem)
        {
            this.model = model;
            this.view = view;
            

            
            view.LoadData += PresenterDecide;
            view.GetLables += PresenterLabels;
            view.GetObjectValues += PresenterValues;
            view.OpenWindow += PresenterNewWindow;
            view.FormClose += PresenterSaveOnClose;


        }

        private object PresenterDecide(string whichDataIsLoaded)
        {
            if (model.studentList == null)
            {
                model.studentList = model.GetStudents("./DBStu.xml");
                model.universitiesList = model.GetUniversities("./DBUni.xml");
            }
            
            if (whichDataIsLoaded == "Students")
            {
                return model.studentList;
            }
            else if(whichDataIsLoaded == "Universities")
            {
                return model.universitiesList;
            }
            else
                return null; 
        }

        private string[] PresenterLabels(string set)
        {
            return model.RetrunLables(set);            
        }

        private string[] PresenterValues(int index)
        {
            return model.ObjectValue(index, view.DataType);            
        }

        private void PresenterEditObject(int index, string[] objectArray)
        {
            model.IfChangesThenSave(index, objectArray, view.DataType);
        }
        private void PresenterNewWindow(string[] labels, string[] values, int index)
        {
            Views.EditItem editItem = new Views.EditItem(labels, values, index);
            editItem.SaveObject += PresenterEditObject;
            editItem.ShowDialog();
            
        }
        private void PresenterSaveOnClose(object sender)
        {
            model.SaveStudentsAndUniversities();
        }
    }
}
