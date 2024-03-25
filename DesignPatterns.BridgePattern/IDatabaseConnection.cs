using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgePattern
{
    public interface IDatabaseConnection
    {
        void Connect();
        void DisConnect();
        void Execute(string query);

    }
}
