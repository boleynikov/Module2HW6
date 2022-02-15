using System;
using Module2HW6.Abstractions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Cars.BMW
{
    public class BMW : AbstractCar
    {
        public override float Speed { get; }

        public override float FuelConsumption { get; }

        public override decimal Price { get; }
        public BMW(float speed, float fuelConsumption, decimal price)
        {
            Speed = speed;
            FuelConsumption = fuelConsumption;
            Price = price;
        }

        public override void Run()
        {
            Console.WriteLine($"Вы едете на стандартной BMW со скоростью {Speed} км/час");
        }
    }
}
