using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorDesignPattern.Visitable;
using VisitorDesignPattern.Visitor;

namespace VisitorDesignPattern.ConcreteVisitable
{
    public class Tobacco : IVisitable
    {
        private double price;
        public Tobacco(double price)
        {
            this.price = price;
        }
        public double accept(IVisitor visitor)
        {
            return visitor.visit(this);
        }
        public double getPrice()
        {
            return price;
        }
    }
}
