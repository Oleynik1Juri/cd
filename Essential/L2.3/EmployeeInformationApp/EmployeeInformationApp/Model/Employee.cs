using System;

namespace EmployeeInformationApp.Model
{
    public class Employee
    {
        private readonly string _name;
        private readonly string _surname;
        public string _employee { get; }

        public Employee(string name, string surname)
        {
            _name = name;
            _surname = surname;
            
        }
        
        public DateTime StartWorkingDate = new DateTime(2020, 10, 10);

        public Employee(string employee)
        {
            _employee = employee;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public double TotalSalary()
        {
            var totalSalary = Math.Round( (1000 + 365) * 0.195, 0);

            return totalSalary;
        }
    }
}