using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Cars.Porsche
{
    class PorscheWithToning : Porsche
    {
        public float ToningPercent { get; }
        public PorscheWithToning(float speed, float fuelConsumption, decimal price, float toningPercent)
            : base(speed, fuelConsumption, price)
        {
            ToningPercent = toningPercent;
        }
        public override void Run()
        {
            Console.WriteLine($"Вы едете на Porsche с тонировкой {ToningPercent} процентов");
        }
    }
}
