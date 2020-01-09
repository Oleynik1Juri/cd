using CurrencyConverter.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConverterTests
{
    [TestClass]
    public class ConverterTests
    {
        private Converter _target;

        [TestInitialize]
        public void Course()
        {
            _target = new Converter(23,30,0.39);
        }
        
        [TestMethod]
        public void ConverterUA_v_USD()
        {
            double actual = _target.ConverterUA_v_USD(23);
            Assert.AreEqual(1,actual);
        }

        [TestMethod]
        public void ConverterUA_v_EUR()
        {
            double actual = _target.ConverterUA_v_EUR(30);
            Assert.AreEqual(1,actual);
        }

        [TestMethod]
        public void ConverterUA_v_RUB()
        {
            double actual = _target.ConverterUA_v_RUB(1000);
            Assert.AreEqual(390,actual);
        }
    }
}
