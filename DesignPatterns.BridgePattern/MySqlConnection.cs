using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgePattern
{
    public class MySqlConnection : IDatabaseConnection
    {
        public void Connect()
        {
            Console.WriteLine("connected msySQL");
        }

        public void DisConnect()
        {
            Console.WriteLine("disconnected msySQL");
        }

        public void Execute(string query)
        {
            Console.WriteLine("{0}",query);
        }
    }
}
