using System;

namespace EmployeeInformationApp.Model
{
    public class Employee
    {
        private readonly string _name;
        private readonly string _surname;
        private readonly string _profession;

        public Employee(string name, string surname, string profession)
        {
            _name = name;
            _surname = surname;
            _profession = profession;
        }

        public override string ToString()
        {
            return "Employee: "+" " + _name +" "+ _surname + _profession;
        }

        public double TotalSalary()
        {
            var totalSalary = Math.Round( (10000 + 365) * 0.195);
            return totalSalary;
        }
    }
}