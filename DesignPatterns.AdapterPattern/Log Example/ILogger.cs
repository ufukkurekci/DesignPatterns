using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.Log_Example
{
    public interface ILogger
    {
        void Log(string message);
    }
}
