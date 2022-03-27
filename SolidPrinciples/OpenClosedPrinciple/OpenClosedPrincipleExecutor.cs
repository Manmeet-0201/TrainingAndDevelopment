using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    class OpenClosedPrincipleExecutor
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(1, "John");
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee(2, "Jason");
            Console.WriteLine(fullTimeEmployee);
            Console.WriteLine(fullTimeEmployee.CalculateBonus(10000));
            Console.WriteLine(partTimeEmployee);
            Console.WriteLine(partTimeEmployee.CalculateBonus(1000));
            Console.ReadKey();
        }
    }
}
