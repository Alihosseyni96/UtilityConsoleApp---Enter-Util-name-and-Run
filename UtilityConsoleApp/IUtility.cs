using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityConsoleApp
{
    internal interface IUtility
    {
        public string Name { get;  }
        void ExecuteContext();
    }
}
