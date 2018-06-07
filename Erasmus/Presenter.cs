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
        }

        private object PresenterGetXMLData(bool StudOrUni)
        {
            if (StudOrUni)
                return model.GetStudents("./DBStu.xml");
            else
                return model.GetUniversities("./DBUni.xml");
        }
    }
}
