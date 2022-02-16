using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Abstractions
{
    public abstract class AbstractCar: IComparable<AbstractCar>
    {
        public abstract float Speed { get; }
        public abstract float FuelConsumption { get; }
        public abstract decimal Price { get; }

        public int CompareTo(AbstractCar car)
        {
            if (car is null) throw new ArgumentException("Это не машина. Не знаю как сравнивать");
            return FuelConsumption.CompareTo(car.FuelConsumption);
        }
        public virtual void Run() { }
    }
}
