using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaOrderSystem.Component;

namespace PizzaOrderSystem.ConcreteComponent
{
    class ChickenPizza : Pizza
    {
        public ChickenPizza()
        {
            Description = "ChickenPizza";
        }
        public override string GetDescription() => Description;

        public override double GetPizzaPrice() => 5.0;
        
    }
}
