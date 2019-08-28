using NUnit.Framework;
using UnitTest.Calculator;
namespace Tests
{
    public class Tests
    {
        Calculator cal;
        [SetUp]
        public void Setup()
        {
            cal = new Calculator();
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(10, cal.Add(5, 5));
        }
       
        
    }
}