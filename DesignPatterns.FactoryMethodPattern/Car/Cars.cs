using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern.Car
{
    public class Cars
    {
        public class Sedan : ICar
        {
            public void GenerateCar()
            {
                Console.WriteLine("sedan araba üretildi");
            }
        }

        public class Suv : ICar
        {
            public void GenerateCar()
            {
                Console.WriteLine("suv araba üretildi");
            }
        }



    }
}
