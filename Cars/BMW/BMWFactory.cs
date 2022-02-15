using Module2HW6.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Cars.BMW
{
    class BMWFactory : Abstractions.AbstractFactory
    {
        public override Models Model { get; }

        public BMWFactory(Models model)
        {
            Model = model;
        }
        public override AbstractCar GetCar()
        {
            var rand = new Random();
            switch (Model)
            {
                case Models.BMW: return new BMW(rand.Next(140, 190), rand.Next(5, 9), rand.Next(500000, 1000000));
                case Models.BMWwithToning: return new BMWwithToning(rand.Next(140, 190), rand.Next(5, 9), rand.Next(500000, 1000000), rand.Next(50,92));
                case Models.BMWwithSpoiler: return new BMWwithSpoiler(rand.Next(140, 190), rand.Next(5, 9), rand.Next(500000, 1000000), rand.Next(50, 92), rand.Next(500,1000));
                case Models.BMWNitro: return new BMWNitro(rand.Next(140, 190), rand.Next(5, 9), rand.Next(500000, 1000000), rand.Next(50, 92), rand.Next(500, 1000), rand.Next(3,8));
                default: return new UnknownCar();
            }
        }
    }
}
