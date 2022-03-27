﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorDesignPattern.Component;
namespace DecoratorDesignPattern.ConcreteComponent
{
    public class CompactCar : AbstractCar
    {
        public CompactCar()
        {
            Description = "Compact Car";
        }

        public override double GetCarPrice() => 10000.00;
        public override string GetDescription() => Description;
    }
}
