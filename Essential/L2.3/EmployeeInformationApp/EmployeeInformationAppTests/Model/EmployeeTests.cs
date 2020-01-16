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
            _target = new Employee("name","surname");
        }

        [TestMethod]
        public void TotalSalaryTest()
        {
            var actual = _target.TotalSalary();
            Assert.AreEqual(266.175, actual);
        }
    }
}