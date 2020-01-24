using System;
using System.Runtime.CompilerServices;
using EmployeeInformationApp.Model;

namespace EmployeeInformationApp
{
    internal class Program
    {
        private static void Main()
        {
            
            Employee employee = new Employee("Oleg","Vardo");
            Console.WriteLine(DateTime.Now.ToString("dd MMMM yyyy"));
            Console.ReadKey();
        }

    }
}