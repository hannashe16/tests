using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinerTests
{
    public class ConsoleLogger: ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
