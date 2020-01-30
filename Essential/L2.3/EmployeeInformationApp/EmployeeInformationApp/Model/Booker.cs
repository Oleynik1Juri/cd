using System;
namespace EmployeeInformationApp.Model
{
    public class Booker
    {
        private readonly double _taxFence;

        public Booker(double taxFence)
        {
            _taxFence = taxFence;
        }

        public double GetSalary(Employee employee)
        {
            var salary = Math.Round((employee.Salary + employee.Days) * _taxFence);
            return salary;
        }
    }
}