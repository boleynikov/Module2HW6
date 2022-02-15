using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Abstractions
{
    public abstract class AbstractFactory
    {
        public abstract Models Model { get; }

        public abstract AbstractCar GetCar();
    }
}
