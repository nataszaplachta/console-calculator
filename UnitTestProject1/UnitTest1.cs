using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using console-calculator;

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
            double expectedResult = 30;

            double actualResult = wynik;

            Assert.AreEqual(expectedResult, actualResult);


        }
        [TestMethod]
        public void TestOdejmowania()
        {

        }
        [TestMethod]
        public void TestMnozenia()
        {

        }
        [TestMethod]
        public void TestDzielenia()
        {

        }
    }
}
