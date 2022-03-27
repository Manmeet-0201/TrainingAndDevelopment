using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Admin : AbstractUser
    {
        public Admin(int ID, string SchoolName)
        {
            this.ID = ID;
            this.Name = SchoolName;
        }
        public override string ProcessLeaves()
        {
            return "The Leaves has been approved";
        }
    }
}
