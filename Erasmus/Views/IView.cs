using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erasmus
{
    public interface IView
    {
        
        event Func<string, object> LoadData;
        event Func<string, string[]> GetLables;
        event Func<int, string[]> GetObjectValues;
        event Action<string[], string[], int> OpenWindow;
        event Action<object> FormClose;

        Students studentsList { get; set; }
        Universities universitiesList { get; set; }
        string DataType { get; set; }
        
    }
}
