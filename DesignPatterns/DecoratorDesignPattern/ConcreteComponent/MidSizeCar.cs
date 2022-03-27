using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorDesignPattern.Component;

namespace DecoratorDesignPattern.ConcreteComponent
{
    public class MidSizeCar : AbstractCar
    {
        public MidSizeCar()
        {
            Description = "MidSize Car";
        }

        public override double GetCarPrice() => 20000.00;
        public override string GetDescription() => Description;
    }
}
