using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityConsoleApp.Utilities
{
    internal class ProductUtility : IUtility
    {
        public string Name => "Product";

        public void ExecuteContext()
        {
            Console.WriteLine("Prouct Added");
        }
    }
}
