using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    class ContractEmployee : IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ContractEmployee()
        {

        }
        public ContractEmployee(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        public decimal GetMinimumSalary()
        {
            return 1000;
        }
        public override string ToString()
        {
            return ID + " " + Name;
        }
    }
}
