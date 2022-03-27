using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorDesignPattern.Iterator;

namespace IteratorDesignPattern.Aggregate
{
    public interface INewspaper
    {
        IIterator CreateIterator();
    }
}
