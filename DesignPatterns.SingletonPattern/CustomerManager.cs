using DesignPatterns.SingletonPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern
{
    public class CustomerManager
    {
        private static CustomerManager _instance;
        static object _instanceLock = new object();

        private CustomerManager()
        {

        }

        public static CustomerManager CreateSingelton()
        {
            lock (_instanceLock)
            {
                if (_instance == null)
                {
                    _instance = new CustomerManager();
                }
                return _instance;
            }
        }

        public void LogTO()
        {
            Console.WriteLine("logged");
        }
    }
}
