using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgePattern
{
    internal class PostgreSqlConnection : IDatabaseConnection
    {
        public void Connect()
        {
            Console.WriteLine("connected postgreSql");
        }

        public void DisConnect()
        {
            Console.WriteLine("disconnected postgreSql");
        }

        public void Execute(string query)
        {
            Console.WriteLine("{0}",query);
        }
    }
}
