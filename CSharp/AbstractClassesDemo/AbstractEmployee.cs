using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesDemo
{
    abstract class AbstractEmployee
    {
        string Name;
        int ID;
        public AbstractEmployee(string Name, int ID)
        {
            this.Name = Name;
            this.ID = ID;
        }
        public abstract float ComputeSalary();
    }
}
