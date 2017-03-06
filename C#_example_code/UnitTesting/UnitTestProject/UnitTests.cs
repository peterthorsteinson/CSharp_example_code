// UnitTests

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestGoodAddIntegers()
        {
            // Arrange
            ClassUnderTest cut = new ClassUnderTest();

            // Act
            int result = cut.GoodAddIntegers(3, 4); // passes

            // Assert
            Assert.AreEqual(result, 3 + 4);
        }
        [TestMethod]
        public void TestBadAddIntegers()
        {
            // Arrange
            ClassUnderTest cut = new ClassUnderTest();

            // Act
            int result = cut.BadAddIntegers(3, 4);

            // Assert
            Assert.AreEqual(result, 3 + 4); // fails
        }
    }
}
