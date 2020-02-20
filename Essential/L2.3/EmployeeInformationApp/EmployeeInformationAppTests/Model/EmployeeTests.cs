using System;
using EmployeeInformationApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeInformationAppTests.Model
{
    [TestClass]
    public class EmployeeTests
    {
        private Employee _target;

        [TestInitialize]
        public void Init()
        {
            _target = new Employee("Ogle", "Vandal", Position.Junior, new DateTime(2000, 12, 31));
        }

        [TestMethod]
        public void ToStringTest()
        {
            var actual = _target.ToString();
            Assert.AreEqual("name: Ogle, surname: Vandal, profession: Junior", actual);
        }

        [TestMethod]
        public void DateStartWorkTest()
        {
            var actual = _target.DateStartWork;
            Assert.AreEqual("31.12.2000", actual);
        }
    }
}