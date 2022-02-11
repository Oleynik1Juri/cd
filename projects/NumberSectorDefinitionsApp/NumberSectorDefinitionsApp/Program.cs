using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSectorDefinitionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 0 до 100: ");
            double number = Convert.ToDouble(Console.ReadLine());
            
            if (number >= 0 && number <= 14)
            {
                Console.WriteLine("Число входит в промежуток 0 - 14");
            }
            else if (number >= 15 && number <= 35)
            {
                Console.WriteLine("Число входит в промежуток 15 - 35");
            }
            else if (number >= 36 && number <= 50)
            {
                Console.WriteLine("Число входит в промежуток 36 - 50");
            }
            else if (number >= 50 && number <= 100)
            {
                Console.WriteLine("Число входит в промежуток 50 - 100");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Число не входит в промежуток от 0 - 100");
            }
           
            Console.ReadKey();
        }
    }
}
