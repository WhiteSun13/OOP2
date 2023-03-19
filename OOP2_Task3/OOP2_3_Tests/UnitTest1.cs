using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OOP2_Task3;

namespace OOP2_3_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SteinTest()
        {
            int a = 123456545;
            int b = 4894895;
            int expected = 5;
            long time;
            Assert.AreEqual(expected, Form1.FindGCDStein(a, b, out time));
        }
        [TestMethod]
        public void NODTest()
        {
            int a = 123456545;
            int b = 4894895;
            int expected = 5;
            long time;
            Assert.AreEqual(expected, Form1.NOD(a, b, out time));
        }
    }
}
