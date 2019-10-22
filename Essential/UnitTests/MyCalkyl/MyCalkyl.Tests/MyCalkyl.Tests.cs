using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalkyl.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Minus_30and20_10returned()
        {
            int x = 30;
            int y = 20;
            int expected = 10;

            MyCalkyl c = new MyCalkyl();
            int actual = c.Minus(x, y);

            Assert.AreEqual(expected,actual);

        }
    }
}
