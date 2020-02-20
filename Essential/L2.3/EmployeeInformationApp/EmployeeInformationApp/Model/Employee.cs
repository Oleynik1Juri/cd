using System;

namespace EmployeeInformationApp.Model
{
    public class Employee
    {
        private readonly string _name;
        private readonly string _surname;
        private readonly Position _profession;


        public Employee(string name, string surname, Position profession, DateTime dateStartWork)
        {
            _name = name;
            _surname = surname;
            _profession = profession;
            DateStartWork = dateStartWork;
        }

        public DateTime DateStartWork { get; set; }

        public double Salary { get; set; }

        public int Position => (int)_profession;

        public override string ToString()
        {
            return $"name: {_name}, surname: {_surname}, profession: {_profession}";
        }
    }
}