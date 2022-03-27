using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionDemo
{
    class CustomerException : Exception
    {
        public CustomerException() : base()
        {

        }
        public CustomerException(string Message) : base(Message)
        {
            Console.WriteLine("In Customer Exception");
        }
    }
}
