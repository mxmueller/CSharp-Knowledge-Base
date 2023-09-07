using UnitTests;

namespace ConverionTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestF2C() // Fahrenheit to Celcius
        {
            double f = 32;
            double c = 0;
            double rvalue = UnitTests.Convert.f2c(f);
            Assert.AreEqual(c, rvalue);
            Assert.AreEqual(100, UnitTests.Convert.f2c(212));
        }

        [TestMethod]
        public void TestC2F()
        {
            Assert.AreEqual(212, UnitTests.Convert.c2f(100));
            Assert.AreEqual(32, UnitTests.Convert.c2f(0));
        }
    }
}