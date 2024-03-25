using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbsractFactoryPattern
{
    public class Nlogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("logged by nlogger");
        }
    }
}
