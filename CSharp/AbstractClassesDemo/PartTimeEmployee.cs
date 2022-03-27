using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractClassesDemo;
namespace AbstractClassesDemo
{
    class PartTimeEmployee : AbstractEmployee
    {
        float DailyWage;
        int NumberOfDays;
        public PartTimeEmployee(string Name, int ID, float DailyWage, int NumberOfDays) : base(Name, ID)
        {
            this.DailyWage = DailyWage;
            this.NumberOfDays = NumberOfDays;
        }
        public override float ComputeSalary()
        {
            return DailyWage * NumberOfDays;
        }
    }
}
