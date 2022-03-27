using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Mocking;
namespace MockingTestProject
{
    [TestClass]
    public class StringSequenceReaderTest
    {
        [TestMethod]
        public void TestReadAll()
        {
            var _mockStringSequence = new Mock<IEnumerable<string>>();
            _mockStringSequence.Setup(m => m.GetEnumerator())
                .Returns(new string[] { "A", "B", "C" }.Select(s => s).GetEnumerator());

            var reader = new StringSequenceReader(_mockStringSequence.Object);

            CollectionAssert.AreEqual(new string[] { "A", "B", "C" }, reader.ReadAll());
        }
    }
}
