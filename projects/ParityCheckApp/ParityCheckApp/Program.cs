using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParityCheckApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для проверки: ");
            var namber = Convert.ToInt32(Console.ReadLine());

            if (namber % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Вы ввели чётное число");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ввели нечётное число");
            }

            Console.ReadKey();
        }
    }
}
