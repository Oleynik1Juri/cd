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

        public Booker()
        {

        }

        public double GetSalary(Employee employee)
        {
            var salary = employee.Salary;
            var taxFence = _taxFence;
            var position = employee.Position;
            var salutatory = Math.Round(salary * taxFence + position + CalculatesNumberOfDays(employee.DateStartWork));
            return salutatory;
        }

        public int CalculatesNumberOfDays(DateTime dateStartWork)
        {
            var dateTimeSpan = DateTime.Now - dateStartWork;
            return Convert.ToInt32(dateTimeSpan.TotalDays);
        }
    }
}