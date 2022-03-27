using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public abstract class AbstractUser
    {
        static string S_SchoolName = "Hyderabad public school";
        public int ID { get; set; }
        public string Name { get; set; }

        public string SchoolName { get { return S_SchoolName; } }
        public abstract string ProcessLeaves();


    }
}
