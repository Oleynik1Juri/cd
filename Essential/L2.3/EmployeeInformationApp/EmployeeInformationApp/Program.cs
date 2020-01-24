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
            

            Console.WriteLine();
            Console.WriteLine(employee.ToString());
            
            
            //Console.WriteLine(employee.StartWorkingDate);
            //Console.Write(employee.TotalSalary());
            Console.WriteLine();
          



            Console.ReadKey();
        }

    }
}