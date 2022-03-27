using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaOrderSystem.Component;

namespace PizzaOrderSystem.Decorator
{
    class PizzaDecorator:Pizza
    {
        protected Pizza _pizza;
        public PizzaDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }
        public override string GetDescription() => _pizza.GetDescription();

        public override double GetPizzaPrice() => _pizza.GetPizzaPrice();
    }
}
