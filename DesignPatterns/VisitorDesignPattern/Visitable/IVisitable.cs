using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorDesignPattern.Visitor;

namespace VisitorDesignPattern.Visitable
{
    public interface IVisitable
    {
        double accept(IVisitor visitor);

    }
}
