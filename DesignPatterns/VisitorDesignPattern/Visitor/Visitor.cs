using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorDesignPattern.ConcreteVisitable;

namespace VisitorDesignPattern.Visitor
{
    public interface IVisitor
    {
        double visit(Liquor liquorItem);

        double visit(Tobacco tobaccoItem);

        double visit(Necessity necessityItem);

    }
}
