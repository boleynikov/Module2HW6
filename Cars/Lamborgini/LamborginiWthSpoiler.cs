using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Cars.Lamborgini
{
    class LamborginiWthSpoiler : LamborginiWithToning
    {
        public float SpoilerLength { get; }
        public LamborginiWthSpoiler(float speed, float fuelConsumption, decimal price, float toningPercent, float spoilerLength)
            : base(speed, fuelConsumption, price, toningPercent)
        {
            SpoilerLength = spoilerLength;
        }
        public override void Run()
        {
            Console.WriteLine($"Вы едете на Lamborgini с тонировкой {ToningPercent} процентов и спойлером длинной {SpoilerLength}");
        }
    }
}
