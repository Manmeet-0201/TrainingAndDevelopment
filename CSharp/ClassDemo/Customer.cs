using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    public class Customer
    {
        private int ID;
        private string _Name;

        public Customer(string name)
        {
            _Name = name;
        }


        public int MyProperty { get; set; }
        public string Name
        {
            get => _Name;
            set
            {
                _Name = "Ramesh";
            }
        }

        public string PrintName
        {
            get { return _Name; }

        }

    }
    public class Child
    {

    }
}
