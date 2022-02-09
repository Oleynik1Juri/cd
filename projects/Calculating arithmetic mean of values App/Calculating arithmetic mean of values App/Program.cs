using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculating_arithmetic_mean_of_values_App
{
    class Program
    {
        static void Main(string[] args)
        {
            var pi = Math.PI;

            int a = 10;
            int b = 5;
            int c = 10;

            int resultant = (a + b + c) / 3;
            Console.WriteLine("a = 10, b = 5, c = 10");
            Console.WriteLine($"Среднее арифметическое число = {resultant}");
            Console.ReadKey();
        }
    }
}