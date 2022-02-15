using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Abstractions;
namespace Module2HW6.Cars.Porsche
{
    class Porsche : AbstractCar
    {
        public override float Speed { get; }

        public override float FuelConsumption { get; }

        public override decimal Price { get; }
        public Porsche(float speed, float fuelConsumption, decimal price)
        {
            Speed = speed;
            FuelConsumption = fuelConsumption;
            Price = price;
        }

        public override void Run()
        {
            Console.WriteLine($"Вы едете на стандартной Porsche со скоростью {Speed} км/час");
        }
    }
}
