using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaOrderSystem.Component;

namespace PizzaOrderSystem.ConcreteComponent
{
    class PepperoniCheesePizza : Pizza
    {
        public PepperoniCheesePizza()
        {
            Description = "PepperoniCheesePizza";
        }
        public override string GetDescription() => Description;

        public override double GetPizzaPrice() => 4.0;
        
    }
}
