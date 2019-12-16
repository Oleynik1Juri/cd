using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Number_comparison.Model;

namespace Number_comparisonTests
{
    [TestClass]
    public class NumberTests
    {
        [TestMethod]
        public void Sum_20and30_50returned()
        {
            int x = 20;
            int y = 30;
            int expected = 50;
            Number c = new Number();
            int actual = c.Sum(x,y);
            Assert.AreEqual(50, actual);
        }
        [TestMethod]
        public void Sub_20and_5_returned()
        {
            int x = 20;
            int y = 5;
            int expected = 15;
            Number c = new Number();
            int actual = c.Sub(x,y);
            Assert.AreEqual(15, actual);
        }
        [TestMethod]
        public void Multiplications_14and7_98returned()
        {
            int x = 14;
            int y = 7;
            int expected = 98;
            Number c = new Number();
            int actual = c.Multiplications(x,y);
            Assert.AreEqual(98, actual);
        }
        [TestMethod]
        public void DivisionByZero_12and2_6returned()
        {
            int x = 12; // /0
            int y = 2;
            int expected = 6;
            Number c = new Number();
            int actual = c.DivisionByZero(x,y);
            Assert.AreEqual(6, actual);
        }
        [TestMethod]
        public void DecimalDivision_10adb4_returned()
        {
            var x = 10.0;
            var y = 4.0;
            double expected = 2.5;
            Number c = new Number();
            var actual = c.DecimalDivision(x,y);
            Assert.AreEqual(2.5, actual);
        }
        [TestMethod]
        public void IncrementPrefix()
        {
            var x = 5;
            var y = ++x;
            int expected = 12;
            Number c = new Number();
            int actual = c.IncrementPrefix(x,y);
            Assert.AreEqual(12, actual);
        }
        [TestMethod]
        public void PostfixIncrement()
        {
            int x = 5;
            int y = --x;
            int expected = 8;
            Number c = new Number();
            int actual = c.PostfixIncrement(x, y);
            Assert.AreEqual(8, actual);
        }
    }
}

