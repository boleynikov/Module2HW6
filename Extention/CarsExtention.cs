using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Extention
{
    public static class CarsExtention
    {
        public static Abstractions.AbstractCar FindCar(this Abstractions.AbstractCar[] cars, decimal fromPrice, decimal toPrice)
        {
            foreach (var car in cars)
            {
                if( car.Price >= fromPrice && car.Price <= toPrice)
                {
                    return car;
                }
            }
            return null;
        }
    }
}
