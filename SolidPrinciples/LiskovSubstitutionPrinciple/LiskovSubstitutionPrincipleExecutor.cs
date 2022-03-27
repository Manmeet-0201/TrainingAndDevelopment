using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    class LiskovSubstitutionPrincipleExecutor
    {
        static void Main(string[] args)
        {
            FullTImeEmployee empJohn = new FullTImeEmployee(1, "John");
            PartTimeEmployee empJason = new PartTimeEmployee(2, "Jason");
            ContractEmployee empMike = new ContractEmployee(3, "Mike");
            List<AbstractEmployee> abstractEmployees = new List<AbstractEmployee>();
            abstractEmployees.Add(empJohn);
            abstractEmployees.Add(empJason);
            foreach (AbstractEmployee emp in abstractEmployees)
            {
                Console.WriteLine(emp);
                Console.WriteLine(emp.CalculateBonus(10000));
                Console.WriteLine(emp.GetMinimumSalary());
            }
            List<IEmployee> iEmployees = new List<IEmployee>();
            iEmployees.Add(empJohn);
            iEmployees.Add(empJason);
            iEmployees.Add(empMike);
            foreach (IEmployee emp in iEmployees)
            {
                Console.WriteLine(emp);
                Console.WriteLine(emp.GetMinimumSalary());
            }
            Console.ReadKey();

        }
    }
}
