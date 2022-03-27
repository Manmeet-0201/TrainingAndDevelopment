using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class ArraysDemoExecutor
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[5];
            CreateGroupOfCustomers(customers);
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer);
            }
            Console.ReadKey();
        }
        private static void CreateGroupOfCustomers(Customer[] GroupOfCustomers)
        {
            GroupOfCustomers[0] = new Customer()
            {
                ID = 101,
                Name = "Steve",
                salary = 3000
            };

            GroupOfCustomers[1] = new Customer()
            {
                ID = 102,
                Name = "John",
                salary = 4500
            };

            GroupOfCustomers[2] = new Customer()
            {
                ID = 103,
                Name = "Jane",
                salary = 4000
            };

            GroupOfCustomers[3] = new Customer()
            {
                ID = 104,
                Name = "Alice",
                salary = 7000
            };

            GroupOfCustomers[4] = new Customer()
            {
                ID = 105,
                Name = "Bob",
                salary = 5500
            };
        }
    }
}
