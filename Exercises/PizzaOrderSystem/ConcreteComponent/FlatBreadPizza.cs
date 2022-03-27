using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaOrderSystem.Component;

namespace PizzaOrderSystem.ConcreteComponent
{
    class FlatBreadPizza : Pizza
    {
        public FlatBreadPizza()
        {
            Description = "FlatBreadPizza";
        }
        public override string GetDescription() => Description;

        public override double GetPizzaPrice() => 6.0;
        
    }
}
