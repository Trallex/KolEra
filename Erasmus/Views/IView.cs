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
        event Action<int> DeleteRecord;
        string DataType { get; set; }
        
    }
}
