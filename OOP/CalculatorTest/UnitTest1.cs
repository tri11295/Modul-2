using NUnit.Framework;
using OOP.UnitTest;

namespace Tests
{
    public class Tests
    {
        public Calculator cal;
        [SetUp]
        public void Setup()
        {
            cal = new Calculator();
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(10, cal.Add(5, 5));
            cal.Add(88, 9);
            Assert.AreEqual(11, cal.Subtract(15, 6));
        }
    }
}