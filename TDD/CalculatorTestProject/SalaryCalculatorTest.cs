using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace SalaryCalculatorTestProject
{
    [TestClass]
    public class SalaryCalculatorTest
    {
        [TestMethod]
        public void TestAnnualSalary()
        {
            SalaryCalculator sc = new SalaryCalculator();
            decimal annualSalary = sc.GetAnnualSalary(50);
            Assert.AreEqual(104000, annualSalary);
        }
        [TestMethod]
        public void TestHourlyWage()
        {
            SalaryCalculator sc = new SalaryCalculator();
            decimal hourlyWage = sc.GetHourlyWage(52000);
            Assert.AreEqual(25, hourlyWage);
        }
    }
}
