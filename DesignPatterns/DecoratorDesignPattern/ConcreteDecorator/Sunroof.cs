using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorDesignPattern.Component;
using DecoratorDesignPattern.Decorator;

namespace DecoratorDesignPattern.ConcreteDecorator
{
    public class Sunroof : CarDecorator
    {
        public Sunroof(AbstractCar car) : base(car)
        {
            Description = "Sunroof";
        }

        public override string GetDescription() => $"{_car.GetDescription()}, {Description}";

        public override double GetCarPrice() => _car.GetCarPrice() + 2500;
    }
}
