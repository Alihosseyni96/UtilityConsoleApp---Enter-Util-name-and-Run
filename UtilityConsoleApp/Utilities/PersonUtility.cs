using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityConsoleApp.Utilities
{
    internal class PersonUtility : IUtility
    {
        public string Name => "Person";

        public void ExecuteContext()
        {
            Console.WriteLine("Person Added");
        }
    }
}
