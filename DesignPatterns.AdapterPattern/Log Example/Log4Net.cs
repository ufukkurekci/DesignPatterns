using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.Log_Example
{
    public class Log4Net
    {
        public void Log4(string message)
        {
            Console.WriteLine("logged with log4");
        }
    }
}
