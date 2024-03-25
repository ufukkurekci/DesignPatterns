using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern.Car
{
    public class CarFactory
    {
        public static ICar CreateCar(string type)
        {
            switch (type.ToLower())
            {
                case "sedan":
                    return new Cars.Sedan();
                case "suv":
                    return new Cars.Suv();
                default:
                    throw new ArgumentException("geçersiz araç");
            }
        }
    }
}
