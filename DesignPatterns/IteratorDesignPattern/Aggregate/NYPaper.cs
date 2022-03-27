using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorDesignPattern.Iterator;
namespace IteratorDesignPattern.Aggregate
{
    public class NYPaper : INewspaper
    {
        private List<string> _reporters;
        public NYPaper()
        {
            _reporters = new List<string>
                        {"John Mesh - NY",
                         "Susanna Lee - NY",
                         "Paul Randy - NY",
                         "Kim Fields - NY",
                         "Sky Taylor - NY"
                        };
        }

        public IIterator CreateIterator()
        {
            return new NYPaperIterator(_reporters);
        }
    }
}
