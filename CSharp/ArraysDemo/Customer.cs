using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class Customer
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public int salary { set; get; }
        public override string ToString()
        {
            return ID + "-" + Name + "-" + salary;
        }
    }
}
