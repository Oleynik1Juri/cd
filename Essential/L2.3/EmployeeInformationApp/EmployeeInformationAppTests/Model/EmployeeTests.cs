using System;
using EmployeeInformationApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeInformationAppTests.Model
{
    [TestClass]
    public class EmployeeTests
    {
        private Employee _target;
        private Profession _target1;

        [TestInitialize]
        public void Init()
        {
            _target = new Employee("Ogle","Vandal");
            _target1= new Profession("","","");
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

        [TestMethod]
        public void ProfessionTest()
        {
            var actual = _target1.ToString();
        }
    }
}