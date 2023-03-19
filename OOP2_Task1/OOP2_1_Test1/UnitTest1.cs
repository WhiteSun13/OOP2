using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP2_Task1;

namespace OOP2_1_Test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NODTest()
        {
            int a = 2806;
            int b = 345;
            int expected = 23;
            Assert.AreEqual(expected, Form1.NOD(a, b));
        }
    }
}
