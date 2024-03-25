using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.Log_Example
{
    public class UKLoggerAdapter : ILogger
    {
        private readonly UKLogger _logger;

        public UKLoggerAdapter()
        {
            _logger = new();
        }

        public void Log(string message)
        {
            Console.WriteLine("logged with UK");
        }
    }
}
