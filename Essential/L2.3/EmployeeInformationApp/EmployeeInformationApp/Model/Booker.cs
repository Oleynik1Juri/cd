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
            var salutatory = Math.Round(employee.Salary * _taxFence + employee.Position + CalculatesNumberOfDays(employee.DateStartWork));
            return salutatory;
        }

        private int CalculatesNumberOfDays(DateTime dateStartWork)
        {
            var dateTimeSpan = DateTime.Now - dateStartWork;
            return Convert.ToInt32(dateTimeSpan.TotalDays);
        }
    }
}