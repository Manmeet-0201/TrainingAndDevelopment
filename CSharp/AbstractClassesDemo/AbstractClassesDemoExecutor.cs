using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractClassesDemo;
namespace AbstractClassesDemo
{
    class AbstractClassesDemoExecutor
    {
        static void Main(string[] args)
        {
            PartTimeEmployee Ramesh = new PartTimeEmployee("Ramesh", 1, 1000, 28);
            Console.WriteLine(Ramesh.ComputeSalary());
            Console.ReadKey();
        }
    }
}
