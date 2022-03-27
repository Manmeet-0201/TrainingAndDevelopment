using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern.Iterator
{
    public interface IIterator
    {
        //  Sets current element to the first element
        void First();
        //  Advances current to next element
        string Next();
        //  Check if end of collection
        bool IsDone();
        //  Check if end of collection
        string CurrentItem();
    }
}
