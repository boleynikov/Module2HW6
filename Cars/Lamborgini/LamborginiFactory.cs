using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Abstractions;
namespace Module2HW6.Cars.Lamborgini
{
    class LamborginiFactory : AbstractFactory
    {
        public override Models Model { get; }

        public LamborginiFactory(Models model)
        {
            Model = model;
        }
        public override AbstractCar GetCar()
        {
            var rand = new Random();
            switch (Model)
            {
                case Models.Lamborgini: return new Lamborgini(rand.Next(140, 190), rand.Next(5, 9), rand.Next(500000, 1000000));
                case Models.LamborginiWithToning: return new LamborginiWithToning(rand.Next(140, 190), rand.Next(5, 9), rand.Next(500000, 1000000), rand.Next(50, 92));
                case Models.LamborginiWithSpoiler: return new LamborginiWthSpoiler(rand.Next(140, 190), rand.Next(5, 9), rand.Next(500000, 1000000), rand.Next(50, 92), rand.Next(500, 1000));
                case Models.LamborginiNitro: return new LamborginiNitro(rand.Next(140, 190), rand.Next(5, 9), rand.Next(500000, 1000000), rand.Next(50, 92), rand.Next(500, 1000), rand.Next(3, 8));
                default: return new UnknownCar();
            }
        }
    }
}
