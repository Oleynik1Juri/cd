using System;
using EmployeeInformationApp.Model;

namespace EmployeeInformationApp
{
    internal class Program
    {
        private static void Main()
        {
            var employee = new Employee("Ogle", "Var-do", Position.Junior);
            Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy"));
            Console.WriteLine(employee.ToString());
            Console.Write("Salary: ");
            Console.ReadKey();
        }
    }
}