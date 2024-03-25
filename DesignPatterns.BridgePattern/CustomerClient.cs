using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgePattern
{
    public class CustomerClient : DatabaseClient
    {
        IDatabaseConnection _connection;
        public CustomerClient(IDatabaseConnection databaseConnection) : base(databaseConnection)
        {
            _connection = databaseConnection;
        }

        public override void GetData()
        {
           _connection.Connect();
           _connection.Execute("select * from customer");
           _connection.DisConnect();
        }
    }
}
