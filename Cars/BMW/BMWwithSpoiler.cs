using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Cars.BMW
{
    class BMWwithSpoiler : BMWwithToning
    {
        public float SpoilerLength { get; }
        public BMWwithSpoiler(float speed, float fuelConsumption, decimal price, float toningPercent, float spoilerLength) 
            : base(speed, fuelConsumption, price, toningPercent)
        {
            SpoilerLength = spoilerLength;
        }
        public override void Run()
        {
            Console.WriteLine($"Вы едете на BMW с тонировкой {ToningPercent} процентов и спойлером длинной {SpoilerLength}");
        }
    }
}
