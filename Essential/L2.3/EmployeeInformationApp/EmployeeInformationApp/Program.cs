using System;
using EmployeeInformationApp.Model;

namespace EmployeeInformationApp
{
    public class Program
    {
        private static void Main()
        {
            var employee = new Employee("Ogle", "Var-do", Position.Junior,new DateTime(2000, 12, 31));
            Console.WriteLine($"Info: {employee}");
            Console.Write($"Salary: {employee.Salary}");
            


            Console.ReadKey();
        }
    }
}