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
        public Presenter(Model model, IView view)
        {
            this.model = model;
            this.view = view;
            view.FillWithXML += PresenterGetXMLData;
            view.LoadData += PresenterDecide;
            view.GetLables += PresenterLabels;
        }

        private object PresenterGetXMLData(bool StudOrUni)
        {
            if (StudOrUni)
                return model.GetStudents("./DBStu.xml");
            else
                return model.GetUniversities("./DBUni.xml");
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
    }
}
