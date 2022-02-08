using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation_of_mathematical_operations_App
{
    class Program
    {
        static void Main(string[] args)
        { 
            int x = 10, y = 12, z = 3;
            Console.WriteLine("Exercise 1 = {0}", x += y - x++ * z);
            x = 10; y = 12; z = 3;
            Console.WriteLine("Exercise 2 = {0}", z = --x - y * 5);
            x = 10; y = 12; z = 3;
            Console.WriteLine("Exercise 3 = {0}", y /= x + 5 % z);
            x = 10; y = 12; z = 3;
            Console.WriteLine("Exercise 4 = {0}", z = x++ + y * 5);
            x = 10; y = 12; z = 3;
            Console.WriteLine("Exercise 5 = {0}", x = y - x++ * z);
            Console.ReadKey();
        }
    }
}
