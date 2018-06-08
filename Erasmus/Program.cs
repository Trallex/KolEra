using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erasmus
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Model model = new Model();
            View view = new View();
            Views.EditItem editItem = new Views.EditItem();
            Presenter p = new Presenter(model, view, editItem);           
            Application.Run(view);
        }
    }
}
