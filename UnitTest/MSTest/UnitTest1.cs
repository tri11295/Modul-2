using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest.Calculator;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        private Calculator cal = new Calculator();
        [TestMethod]
        public void AddTest()
        {
            Assert.IsTrue(cal.Add(1,1) == 2);
            Assert.AreEqual(20, cal.Add(10, 10));

        }
        public void SubtractTest()
        {
            Assert.IsTrue(cal.Add(2, 1) == 1);

        }
    }
}
