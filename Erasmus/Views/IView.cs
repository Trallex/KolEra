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

        Students studentsList { get; set; }
        Universities universitiesList { get; set; }
        string DataType { get; set; }
        
    }
}
