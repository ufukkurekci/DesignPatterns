using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbsractFactoryPattern
{
    public class RedisCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("cache with redis");
        }
    }
}
