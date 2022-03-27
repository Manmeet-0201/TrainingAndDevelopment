using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaOrderSystem.Component;
using PizzaOrderSystem.Decorator;

namespace PizzaOrderSystem.ConcreteDecorator
{
    class Onion : PizzaDecorator
    {
        public Onion(Pizza pizza) : base(pizza)
        {
            Description = "Onion";
        }
        public override string GetDescription() =>
                               $"{_pizza.GetDescription()},  {Description}";


        public override double GetPizzaPrice() => _pizza.GetPizzaPrice() + 0.5;

    }
}
