using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Number_comparison.Model;

namespace Number_comparisonTests
{
    [TestClass]
    public class NumberTests
    {
        [TestMethod]
        public void Plus_20and30_50returned()
        {
            int x = 20;
            int y = 30;
            int expected = 50;
            Number c = new Number();
            int actual = c.Plus(x, y);
            Assert.AreEqual(50, actual);
        }
        [TestMethod]
        public void Minus_20and_5_returned()
        {
            int x = 20;
            int y = 5;
            int expected = 15;
            Number c = new Number();
            int actual = c.Minus(x, y);
            Assert.AreEqual(15, actual);
        }
        [TestMethod]
        public void Multiplications_14and7_98returned()
        {
            int x = 14;
            int y = 7;
            int expected = 98;
            Number c = new Number();
            int actual = c.Multiplications(x, y);
            Assert.AreEqual(98, actual);
        }
        [TestMethod]
        public void Divisions_12and2_6returned()
        {
            int x = 12;
            int y = 2;
            int expected = 6;
            Number c = new Number();
            int actual = c.Divisions(x, y);
            Assert.AreEqual(6, actual);
        }
        [TestMethod]
        public void ReceiptOfBalance_10adb4_returned()
        {
            double x = 10.0;
            double y = 4.0;
            int expected = 2;
            Number c = new Number();
            int actual = c.ReceiptOfBalance( x,  y);
            Assert.AreEqual(2,actual);
        }
        
    }
}

