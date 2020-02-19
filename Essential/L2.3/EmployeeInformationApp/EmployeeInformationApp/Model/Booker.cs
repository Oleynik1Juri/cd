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
            var salary = Math.Round(employee.Salary + _taxFence * CalculatesNumberOfDays(employee.DateStartWork));
            return salary;
        }

        private int CalculatesNumberOfDays(DateTime dateStartWork)
        {
            var dateTimeSpan = DateTime.Now - dateStartWork;
            return Convert.ToInt32(dateTimeSpan.TotalDays);
        }
    }
}