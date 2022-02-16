using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Abstractions;
namespace Module2HW6.Cars.Porsche
{
    class PorscheFactory: AbstractFactory
    {
        public override Models Model { get; }

        public PorscheFactory(Models model)
        {
            Model = model;
        }
        public override AbstractCar GetCar()
        {
            var rand = new Random();
            switch (Model)
            {
                case Models.Porsche: return new Porsche(rand.Next(140, 190), rand.Next(5, 9), rand.Next(500000, 1000000));
                case Models.PorscheWithToning: return new PorscheWithToning(rand.Next(140, 190), rand.Next(5, 9), rand.Next(500000, 1000000), rand.Next(50, 92));
                case Models.PorscheWithSpoiler: return new PorscheWithSpoiler(rand.Next(140, 190), rand.Next(5, 9), rand.Next(500000, 1000000), rand.Next(50, 92), rand.Next(500, 1000));
                case Models.PorsceNitro: return new PorscheNitro(rand.Next(140, 190), rand.Next(5, 9), rand.Next(500000, 1000000), rand.Next(50, 92), rand.Next(500, 1000), rand.Next(3, 8));
                default: return new UnknownCar();
            }
        }
    }
}
