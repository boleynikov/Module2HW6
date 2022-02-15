using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Cars.Lamborgini
{
    class LamborginiNitro : LamborginiWthSpoiler
    {
        public float NitroInterval { get; }
        public LamborginiNitro(float speed, float fuelConsumption, decimal price, float toningPercent, float spoilerLength, float nitroInterval)
            : base(speed, fuelConsumption, price, toningPercent, spoilerLength)
        {
            NitroInterval = nitroInterval;
        }
        public override void Run()
        {
            Console.WriteLine($"Вы едете на NITRO версии Lamborgini, можно разогнаться до скорости света на протяжении {NitroInterval} секунд");
        }
    }
}
