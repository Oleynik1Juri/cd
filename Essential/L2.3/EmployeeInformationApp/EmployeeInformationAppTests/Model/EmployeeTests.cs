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
            _target = new Employee("Ogle","Vandal");
        }
        
        [TestMethod]
        public void TotalSalaryTest()
        {
            var actual = _target.TotalSalary();
            Assert.AreEqual(266, actual);
        }

       [TestMethod]

        public void StartWorkingDateTest()
        {
            var actual = _target.ToString();
        }

    }
}