using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    class SingleResponsibilityPrincipleExecutor
    {
        static void Main(string[] args)
        {
            string orderValue = Console.ReadLine();
            OrderProcessor orderProcessor = new OrderProcessor(orderValue);
            orderProcessor.Process();
            Console.ReadKey();

        }
    }
}
