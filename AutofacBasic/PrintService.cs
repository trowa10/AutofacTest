using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacBasic
{
    public class PrintService : IPrintService
    {
        public void PrintSomething(string text)
        {
            Console.WriteLine(text);
        }
    }
}
