using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using console_calculator;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDodawania()
        {
            double a = 10;
            double b = 20;
            double expectedResult = a+b;
            

            Assert.AreEqual(expectedResult, 30);


        }
        [TestMethod]
        public void TestOdejmowania()
        {
            double a = 20;
            double b = 10;
            double expectedResult = a-b;
            

            Assert.AreEqual(expectedResult, 10);

        }
        [TestMethod]
        public void TestMnozenia()
        {
            double a = 5;
            double b = 4;
            double expectedResult = a*b;
            

            Assert.AreEqual(expectedResult, 20);
        }
        [TestMethod]
        public void TestDzielenia()
        {
            double a = 20;
            double b = 5;
            double expectedResult = a/b;
            

            Assert.AreEqual(expectedResult, 4);

        }
    }
}
