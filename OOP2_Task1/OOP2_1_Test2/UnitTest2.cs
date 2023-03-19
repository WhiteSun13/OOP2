using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP2_Task1;

namespace OOP2_1_Test2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod()]
        public void Test1()
        {
            int a = 12;
            int b = 24;
            int expected = 12;
            Assert.AreEqual(expected, Form1.NOD(a, b));
        }

        [TestMethod()]
        public void Test2()
        {
            int a = 7396;
            int b = 1978;
            int c = 1204;
            int expected = 86;
            Assert.AreEqual(expected, Form1.NOD(a, b, c));
        }

        [TestMethod()]
        public void Test3()
        {
            int a = 7396;
            int b = 1978;
            int c = 1204;
            int d = 430;
            int expected = 86;
            Assert.AreEqual(expected, Form1.NOD(a, b, c, d));
        }

        [TestMethod()]
        public void Test4()
        {
            int a = 7396;
            int b = 1978;
            int c = 1204;
            int d = 430;
            int e = 258;
            int expected = 86;
            Assert.AreEqual(expected, Form1.NOD(a, b, c, d, e));
        }
    }
}
