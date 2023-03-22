using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Big_packClassLibrary.Tests1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            int a = 2600;
            int b = 400;
            int expected = 6;

            //act
            Class1 c = new Class1();
            int actual = c.Del(a, b);

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
