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
            var taxFence = 0.195;
            _target = new Booker(taxFence);
        }

        [TestMethod]
        public void GetSalaryTest()
        {
            var employee = new Employee("Ogle", "Vandal", Position.Junior);
            var actual = _target.GetSalary(employee);
            Assert.AreEqual(2021, actual);
        }
    }
}