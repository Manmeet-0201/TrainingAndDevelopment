using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public abstract class AbstractEmployee : IEmployee, IEmployeeBonus
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public AbstractEmployee()
        {

        }
        public AbstractEmployee(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        public abstract decimal CalculateBonus(decimal salary);
        public abstract decimal GetMinimumSalary();
        public override string ToString()
        {
            return ID + " " + Name;
        }
    }
}
