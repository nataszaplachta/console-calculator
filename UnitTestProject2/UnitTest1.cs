using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            
            double actualResult = ;

            Assert.AreEqual(expectedResult, actualResult);


        }
        [TestMethod]
        public void TestOdejmowania()
        {
            double a = 20;
            double b = 10;
            double expectedResult = 10;

            double actualResult = ;

            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void TestMnozenia()
        {
            double a = 5;
            double b = 4;
            double expectedResult = 20;

            double actualResult = ;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestDzielenia()
        {
            double a = 20;
            double b = 5;
            double expectedResult = 4;

            double actualResult = ;

            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
