using System;
using EmployeeInformationApp.Model;

namespace EmployeeInformationApp
{
    internal class Program
    {
        private static void Main()
        {
            Employee employee = new Employee("Vadim", "Ivanov");
            Console.WriteLine($"Information: Vadim Ivanov, junior.");
            Console.Write($@"Salary: ".ToString());
            Console.Write(employee.TotalSalary());
            employee.TotalSalary();
            
            Console.ReadKey();
        }
    }
}