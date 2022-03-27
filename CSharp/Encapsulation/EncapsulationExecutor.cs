using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class EncapsulatioExecutor
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Mark", 101);
            c1.PrintDetails();
            Customer c2 = new Customer();
            c2.ID = 102;
            c2.Name = "John";
            c2.PrintDetails();
            Customer c3 = new Customer { ID = 103, Name = "Lisa" };
            c3.PrintDetails();
        }
    }
}
