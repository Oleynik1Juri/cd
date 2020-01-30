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
            _target = new Employee("Ogle", "Vandal", Position.Junior);
        }

        [TestMethod]
        public void ToStringTest()
        {
            var actual = _target.ToString();
            Assert.AreEqual("name: Ogle, surname: Vandal, profession: Junior", actual);
        }
    }
}