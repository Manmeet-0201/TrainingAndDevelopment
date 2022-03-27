using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorDesignPattern.Component;

namespace DecoratorDesignPattern.Decorator
{
    public class CarDecorator : AbstractCar
    {
        protected AbstractCar _car;
        public CarDecorator(AbstractCar car)
        {
            _car = car;
        }

        public override double GetCarPrice() => _car.GetCarPrice();

        public override string GetDescription() => _car.GetDescription();
    }
}
