using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123_S2016_Lesson2;
namespace Unit_Test_Lesson2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void addXandYTestMethod()
        {
            //Arrange 
            int x = 40;
            int y = 50;
            int expectedResult = 90;

            //Act
            int result = Program.addXandY(x, y);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void addYtoXTestMethod()
        {
            //Arrange 
            int x = 40;
            int y = 50;
            int expectedResult = 90;

            //Act
            int result = Program.addYtoX(ref x, ref y);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}