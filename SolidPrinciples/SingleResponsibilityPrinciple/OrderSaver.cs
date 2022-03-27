using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class OrderSaver
    {
        public void Save(string orderValue)
        {
            Console.WriteLine(orderValue + " is saved");
        }

    }
}
