using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erasmus.Views
{
    public interface IAddItem
    {
        event Action<string[]> AddNewObject;
    }
}
