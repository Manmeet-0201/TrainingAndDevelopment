using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Customer
    {
        private int _id;
        private string _name;
        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public Customer()
        {

        }
        public Customer(int Id) : this("Hello", Id)
        {
            this._id = Id;
            //this._name = Name;
            //this.Email = email;
        }
        public Customer(string Name, int id)
        {
            this._id = id;
            this._name = Name;
        }
        public void PrintDetails()
        {
            Console.WriteLine(this._id + " " + this._name);
        }
    }
}
