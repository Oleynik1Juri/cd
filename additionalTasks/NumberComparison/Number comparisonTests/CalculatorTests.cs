using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Number_comparison.Model;

namespace Number_comparisonTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Sum_20and30_50Tests()
        {
            
            var x = 20;
            var y = 30;
            var expected = 50;
            var c = new Calculator();
            var actual = c.Sum(x,y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sub_20and_5_Tests()
        {

            var x = 20;
            var y = 5;
            var expected = 15;
            var c = new Calculator();
            var actual = c.Sub(x,y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiplications_14and7_98Tests()
        {
            
            var x = 14;
            var y = 7;
            var expected = 98;
            var c = new Calculator();
            var actual = c.Multiplications(x,y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Division_2and0_0Tests()
        {
           
            var x = 2;
            var y = 0;
            var targetCalculator = new Calculator();
            targetCalculator.Division(x, y);
           
        }
        [TestMethod]
        public void DecimalDivision_10adb4_Tests()
        {
            
            var x = 10.0;
            var y = 4.0;
            var expected = 2.5;
            var c = new Calculator();
            var actual = c.DecimalDivision(x,y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IncrementTests()
        {
            
            var x = 5;
            var expected = 5;
            var c = new Calculator();
            var actual = c.Increment(x);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DecrementTests()
        {
            
            var x = 13;
            var expected = 12;
            var c = new Calculator();
            var actual = c.Decrement(x);
            Assert.AreEqual(expected, actual);
        }
    }
}