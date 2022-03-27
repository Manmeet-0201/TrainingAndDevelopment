using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class OrderValidator
    {
        public void Validate(string orderValue)
        {
            Console.WriteLine(orderValue + " " + "Validate of order");
        }
    }
}
