using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class FullTimeEmployee : AbstractEmployee
    {
        public FullTimeEmployee(int ID, string Name) : base(ID, Name)
        {

        }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }
}
