using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorDesignPattern.ConcreteVisitable;
using VisitorDesignPattern.Visitor;

namespace VisitorDesignPattern.ConcreteVisitor
{
    public class TaxHolidayVisitor : IVisitor
    {
        public double visit(Liquor liquorItem)
        {
            Console.WriteLine("Taxing liquor item on holiday");
            return liquorItem.getPrice() * 0.12 + liquorItem.getPrice();
        }

        public double visit(Tobacco tobaccoItem)
        {
            Console.WriteLine("Taxing tobacco item on holiday");
            return tobaccoItem.getPrice() * 0.22 + tobaccoItem.getPrice();
        }

        public double visit(Necessity necessityItem)
        {
            Console.WriteLine("Taxing necessity item on holiday");
            return necessityItem.getPrice() * 0.1 + necessityItem.getPrice();
        }
    }
}
