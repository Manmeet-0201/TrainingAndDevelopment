using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public abstract class AbstractEmployee
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
        public override string ToString()
        {
            return ID + " " + Name;
        }
    }
}
