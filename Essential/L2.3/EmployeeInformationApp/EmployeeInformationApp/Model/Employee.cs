using System;

namespace EmployeeInformationApp.Model
{
    public class Employee
    {
        private readonly string _name;
        private readonly string _surname;
        private readonly Position _profession;


        public Employee(string name, string surname, Position profession)
        {
            _name = name;
            _surname = surname;
            _profession = profession;
        }

        public double Salary => (int)_profession;
        public int Days => 365;

        public double TotalSalary()
        {
            var totalSalary = Math.Round( (10000 + 365) * 0.195);
            return totalSalary;
        }

        public override string ToString()
        {
            return $"name: {_name}, surname: {_surname}, profession: {_profession}";
        }
    }
}