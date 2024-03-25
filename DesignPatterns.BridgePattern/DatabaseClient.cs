using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgePattern
{
    public abstract class DatabaseClient
    {
        private IDatabaseConnection _connection;
        protected DatabaseClient(IDatabaseConnection databaseConnection)
        {
            _connection = databaseConnection;
        }
        public abstract void GetData(); 
    }
}
