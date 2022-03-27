using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;
namespace EssentialTrainingTest
{
    [TestClass]
    public class Class1Test
    {
        [TestMethod]
        public void TestAddTwo()
        {

            var testInstance = new Class1();
            var testResult = testInstance.AddTwo(9, 5);
            Assert.AreEqual(14, testResult, "I Expect 9+5 to be 14");
        }
    }
}
