using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DelegatesDemo
{
    class DelegatesDemoExecutor
    {
        static void Main(string[] args)
        {
            List<Employee> ListOfEmployees = new List<Employee>();

            ListOfEmployees.Add(new Employee() { ID = 101, Name = "Arjun", Experience = 5 });
            ListOfEmployees.Add(new Employee() { ID = 102, Name = "Varun", Experience = 4 });
            ListOfEmployees.Add(new Employee() { ID = 103, Name = "Vishal", Experience = 7 });

            IsPromotable isPromotable = new IsPromotable(CheckForPromotionEligibility);

            Employee.CheckForPromotionEligibility(ListOfEmployees, isPromotable);
        }

        public static bool CheckForPromotionEligibility(Employee employee)
        {
            if (employee.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    delegate bool IsPromotable(Employee employee);

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }

        public static void CheckForPromotionEligibility(List<Employee> EmployeeList, IsPromotable IsEligibleToPromote)
        {
            foreach (Employee employee in EmployeeList)
            {
                if (IsEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " is eligible for promotion.");
                }
            }
        }
    }
}

