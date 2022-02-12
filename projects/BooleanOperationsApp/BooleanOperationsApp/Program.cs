using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanOperationsApp
{
    class Program
    {
        static void Main()
        {
            var x = 5;
            var y = 10;
            var z = 15;
            
            Console.WriteLine("Задача: x += y >> x++ * z");
            var result = x += y >> x++ * z;
            Console.WriteLine($"Результат = {result}");
            Console.WriteLine("------------------------");

            Console.WriteLine("Задача: z = ++x & y * 5");
            var result1 = z = ++x & y * 5;
            Console.WriteLine($"Результат = {result1}");    
            Console.WriteLine("-----------------------");

            Console.WriteLine("Задача: y /= x + 5 | z");
            var result2 = y /= x + 5 | z;
            Console.WriteLine($"Результат: {result2}");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Задача: z = x++ & y * 5");
            var result3 = z = x++ & y * 5;
            Console.WriteLine($"Результат: {result3}");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Задача: x = y << x++ ^ z");
            var result4 = x = y << x++ ^ z;
            Console.WriteLine($"Результат: {result4}");
            
            Console.ReadKey();
        }
            
    }
}
