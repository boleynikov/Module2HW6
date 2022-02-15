using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Cars.BMW
{
    class BMWNitro : BMWwithSpoiler
    {
        public float NitroInterval { get; }
        public BMWNitro(float speed, float fuelConsumption, decimal price, float toningPercent, float spoilerLength, float nitroInterval) 
            : base(speed, fuelConsumption, price, toningPercent, spoilerLength)
        {
            NitroInterval = nitroInterval;
        }
        public override void Run()
        {
            Console.WriteLine($"Вы едете на NITRO версии BMW, можно разогнаться до скорости света на протяжении {NitroInterval} секунд");
        }
    }
}
