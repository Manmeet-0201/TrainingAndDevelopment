using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class SchoolExecutor
    {
        static void Main(string[] args)
        {
            Staff staff = new Staff(1, "Ramesh");
            Admin admin = new Admin(2, "Haider");
            Console.WriteLine(staff.SchoolName);
            Console.WriteLine(staff.ProcessLeaves());
            Console.ReadKey();
        }
    }
}
