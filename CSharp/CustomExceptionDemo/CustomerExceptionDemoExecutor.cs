using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomExceptionDemo;
namespace CustomExceptionDemo
{
    class CustomExceptionDemoExecutor
    {
        static void Main(string[] args)
        {
            try
            {
                throw new CustomerException("Customer logged out");
            }
            catch (CustomerException customerexception)
            {
                Console.WriteLine(customerexception.Message);
                Console.ReadKey();
            }
        }
    }
}
