using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Staff : AbstractUser
    {
        public Staff(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        public override string ProcessLeaves()
        {
            return "The Leaves has been applied";
        }


    }
}
