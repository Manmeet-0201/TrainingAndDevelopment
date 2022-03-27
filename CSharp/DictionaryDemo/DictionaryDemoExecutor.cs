using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DictionaryDemo;
namespace DictionaryDemo
{
    class DictionaryDemoExecutor
    {
        static void Main(string[] args)
        {
            Customer[] GroupOfCustomers = new Customer[5];
            DictionaryDemoExecutor.AddGroupOfCustomers(GroupOfCustomers);

            Dictionary<int, Customer> CustomerDataDictionary = new Dictionary<int, Customer>();

            foreach (Customer customer in GroupOfCustomers)
            {
                CustomerDataDictionary.Add(customer.ID, customer);
            }


            //Code to get value of an element with a specific key
            Console.WriteLine("Name of customer with ID=103 is " + CustomerDataDictionary[103].Name);

            try
            {
                Console.WriteLine("Name of customer with ID=106 is " + CustomerDataDictionary[106].Name);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Customer with ID 106 does not exist");
            }

            //Code to find the number of customers whose salary is greater than 5000 in the dictionary
            Console.WriteLine(CustomerDataDictionary.Count(customer => customer.Value.salary >= 5000));

            //Code if you are not sure whether a key is present in the dictionary
            //but do not want the code to throw any exception 
            int TemporaryCustomerID = 105;
            if (CustomerDataDictionary.TryGetValue(TemporaryCustomerID, out Customer ExistingCustomer))
            {
                Console.WriteLine("Details of customer with ID as {0} : Name is {1} Salary is {2}", TemporaryCustomerID, ExistingCustomer.Name, ExistingCustomer.salary);
            }
            else
            {
                Console.WriteLine("Invalid ID");
            }

            //Code to remove all entries in the dictionary
            CustomerDataDictionary.Clear();

            Console.WriteLine(CustomerDataDictionary.Count);

            Customer[] customers = new Customer[3];
            customers[0] = GroupOfCustomers[0];
            customers[1] = GroupOfCustomers[1];
            customers[2] = GroupOfCustomers[2];

            Dictionary<int, Customer> dict = customers.ToDictionary(customer => customer.ID, customer => customer);

            foreach (KeyValuePair<int, Customer> CustomerData in dict)
            {
                Console.WriteLine("Key is {0} and value is {1}", CustomerData.Key, CustomerData.Value.Name);
            }
        }
        private static void AddGroupOfCustomers(Customer[] GroupOfCustomers)
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
