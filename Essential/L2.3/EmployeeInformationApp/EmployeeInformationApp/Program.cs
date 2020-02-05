using System;
using EmployeeInformationApp.Model;

namespace EmployeeInformationApp
{
    public class Program
    {
        private static void Main()
        {
            var employee = new Employee("Ogle", "Var-do", Position.Junior);
            Console.Write("Start Work: ");
            Console.WriteLine(DateTime.Now.ToString("yyyy"));
            Console.WriteLine(employee.ToString());
            Console.Write("Salary: ");
            Console.ReadKey();
        }
    }
}