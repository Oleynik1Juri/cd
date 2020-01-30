using System;
using EmployeeInformationApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeInformationAppTests.Model
{
    [TestClass]
    public class BookerTests
    {
        private Booker _target;

        [TestInitialize]
        public void Init()
        {
            _target = new Booker();

        }
        
        [TestMethod]
        public void GetSalaryTest()
        {
            var actual = _target.GetSalary();
            Assert.AreEqual(25000,actual);
        }
    }
}
