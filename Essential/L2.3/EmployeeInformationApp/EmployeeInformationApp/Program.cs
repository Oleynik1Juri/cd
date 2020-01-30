using System;
using System.Runtime.CompilerServices;
using EmployeeInformationApp.Model;

namespace EmployeeInformationApp
{
    internal class Program
    {
        private static void Main()
        {
            var employee = new Employee("Oleg","Vardo",Position.Junior);
            //var employee = new Employee("Oleg", "Vardo", " ","");
            Console.WriteLine(DateTime.Now.ToString("dd MMMM yyyy"));
            Console.WriteLine(employee.ToString());
            Console.Write("Salary: ");
            Console.Write(employee.TotalSalary());
            Console.ReadKey();
        }
    }
}