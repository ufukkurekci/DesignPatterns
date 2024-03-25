using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.Log_Example
{
    public class UKLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("logged with UK logger, {0}",message);
        }
    }
}
