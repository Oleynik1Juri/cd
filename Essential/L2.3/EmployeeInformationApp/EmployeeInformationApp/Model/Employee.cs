using System;
namespace EmployeeInformationApp.Model
{
    public class Employee
    {
        private readonly string _name;
        private readonly string _surname;
        private readonly DateTime _startWorkingDate;
        
        public Employee(string name, string surname, DateTime startWorkingDate)
        {
            _name = name;
            _surname = surname;
            _startWorkingDate = startWorkingDate;
        }
        private enum Profession
        {
            Junion,
            Middel,
            Senior
        }

        public double TotalSalary()
        {
            var totalSalary = (1000 + 365) * 0.195;

            return totalSalary;
        }
    }
}     