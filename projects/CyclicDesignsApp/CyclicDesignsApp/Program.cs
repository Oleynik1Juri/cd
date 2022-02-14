using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclicDesignsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число b: ");
            var b = Convert.ToInt32(Console.ReadLine());

            var result = 0;

            for (var x = a; a < b; a++)
            {
                if ((a % 2) != 0)
                {
                    Console.WriteLine("{0} ", a);
                }

                result += a;
            }

            Console.WriteLine("Сума чисел {0}", result);
            Console.ReadKey();
        }
    }
}
