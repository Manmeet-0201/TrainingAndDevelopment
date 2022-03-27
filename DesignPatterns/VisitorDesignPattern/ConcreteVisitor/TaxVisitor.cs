using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorDesignPattern.ConcreteVisitable;
using VisitorDesignPattern.Visitor;

namespace VisitorDesignPattern.ConcreteVisitor
{
    public class TaxVisitor : IVisitor
    {
        public double visit(Liquor liquorItem)
        {
            Console.WriteLine("Taxing liquor item");
            return liquorItem.getPrice() * 0.20 + liquorItem.getPrice();
        }

        public double visit(Tobacco tobaccoItem)
        {
            Console.WriteLine("Taxing Tobacco item");
            return tobaccoItem.getPrice() * 0.30 + tobaccoItem.getPrice();
        }

        public double visit(Necessity necessityItem)
        {
            Console.WriteLine("Taxing necessity item");
            return necessityItem.getPrice() * 0.1 + necessityItem.getPrice();
        }
    }
}
