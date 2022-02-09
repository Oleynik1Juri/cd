using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculating_the_area_of_a_circle_App
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            Console.WriteLine("pi = 3.14");
            Console.Write("r = ");
            int.TryParse(Console.ReadLine(), out var r);
            var s = pi * Math.Pow(r, 2);
            Console.WriteLine("Area of a circle = {0}", s);
            Console.ReadKey();

        }
    }
}
