using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polymorphism;
namespace PolymorphismTestProject
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void TestCalculateWeeklySalaryForEmployeeTest()
        {
            //Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = 40 * wage;
            Employee e = new Employee();
            string expectedResponse = String.Format("\nThis ANGRY EMPLOYEE worked {0} hrs. " +
                                  "Paid for 40 hrs at $ {1}" +
                                  "/hr = ${2} \n", weeklyHours, wage, salary);

            //Act
            string actualRespone = e.CalculateWeeklySalary(weeklyHours, wage);
            Assert.AreEqual(expectedResponse, actualRespone);

        }
        public void TestCalculateWeeklySalaryForContractorTest()
        {
            //Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = weeklyHours * wage;
            Employee e = new Contractor();
            string expectedResponse = String.Format("\nThis HAPPY CONTRACTOR worked {0} hrs. " +
                                  "Paid for {0} hrs at $ {1}" +
                                  "/hr = ${2} ", weeklyHours, wage, salary);

            //Act
            string actualRespone = e.CalculateWeeklySalary(weeklyHours, wage);
            Assert.AreEqual(expectedResponse, actualRespone);

        }
        public void TestCalculateWeeklySalaryForEmployeeTestDoesNotReturnCorrectString()
        {
            //Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = 40 * wage;
            Employee e = new Employee();
            string expectedResponse = String.Format("\nProblem 1-This ANGRY EMPLOYEE worked {0} hrs. " +
                                  "Paid for 40 hrs at $ {1}" +
                                  "/hr = ${2} \n", weeklyHours, wage, salary);

            //Act
            string actualRespone = e.CalculateWeeklySalary(weeklyHours, wage);
            Assert.AreNotEqual(expectedResponse, actualRespone);

        }
        public void TestCalculateWeeklySalaryForContractorTestDoesNotReturnCorrectString()
        {
            //Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = weeklyHours * wage;
            Employee e = new Contractor();
            string expectedResponse = String.Format("\nProblem 2-This HAPPY CONTRACTOR worked {0} hrs. " +
                                  "Paid for {0} hrs at $ {1}" +
                                  "/hr = ${2} ", weeklyHours, wage, salary);

            //Act
            string actualRespone = e.CalculateWeeklySalary(weeklyHours, wage);
            Assert.AreNotEqual(expectedResponse, actualRespone);

        }
    }
}
