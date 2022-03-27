using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaOrderSystem.Component;
using PizzaOrderSystem.Decorator;

namespace PizzaOrderSystem.ConcreteDecorator
{
    class BlackOlive:PizzaDecorator
    {
        public BlackOlive(Pizza pizza) : base(pizza)
        {
            Description = "BlackOlive";
        }
        public override string GetDescription() =>
                               $"{_pizza.GetDescription()},  {Description}";


        public override double GetPizzaPrice() => _pizza.GetPizzaPrice() + 1.3;

    }
}
