using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Cars.Porsche
{
    class PorscheWithSpoiler : PorscheWithToning
    {
        public float SpoilerLength { get; }
        public PorscheWithSpoiler(float speed, float fuelConsumption, decimal price, float toningPercent, float spoilerLength)
            : base(speed, fuelConsumption, price, toningPercent)
        {
            SpoilerLength = spoilerLength;
        }
        public override void Run()
        {
            Console.WriteLine($"Вы едете на Porsche с тонировкой {ToningPercent} процентов и спойлером длинной {SpoilerLength}");
        }
    }
}
