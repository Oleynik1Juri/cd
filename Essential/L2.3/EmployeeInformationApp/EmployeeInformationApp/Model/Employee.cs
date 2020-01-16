using System;

namespace EmployeeInformationApp.Model
{
    public class Employee
    {
        private readonly string _name;
        private readonly string _surname;

        public Employee(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }
       
        public double TotalSalary()
        {
            var totalSalary = (1000 + 365) * 0.195;

            return totalSalary;
        }
    }
}     