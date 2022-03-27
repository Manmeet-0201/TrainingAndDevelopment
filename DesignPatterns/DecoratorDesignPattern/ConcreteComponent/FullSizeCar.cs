using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorDesignPattern.Component;

namespace DecoratorDesignPattern.ConcreteComponent
{
    public class FullSizeCar : AbstractCar
    {
        public FullSizeCar()
        {
            Description = "FullSize Car";
        }

        public override double GetCarPrice() => 30000.00;
        public override string GetDescription() => Description;
    }
}
