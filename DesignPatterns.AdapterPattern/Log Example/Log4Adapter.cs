using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.Log_Example
{
    public class Log4Adapter : ILogger
    {
        private Log4Net _log4Net;

        public Log4Adapter()
        {
            _log4Net = new Log4Net();
        }

        public void Log(string message)
        {
            _log4Net.Log4(message);
        }
    }
}
