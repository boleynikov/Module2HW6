using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Cars
{
    class UnknownCar : Abstractions.AbstractCar
    {
        public override float Speed => throw new NotImplementedException();

        public override float FuelConsumption => throw new NotImplementedException();

        public override decimal Price => throw new NotImplementedException();

        public override void Run()
        {
            throw new ArgumentException("Такой машины нету");
        }
    }
}
