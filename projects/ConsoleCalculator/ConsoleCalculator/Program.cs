using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main()
        {
            
            double operand2;

            Console.WriteLine("Введите первое число: ");
            Console.Write("");
            int operand1;
            int.TryParse(Console.ReadLine(), out operand1);

            Console.WriteLine("Ввести арифметический знак: ");
            var sign = Console.ReadLine();

            Console.Write("Введите второе число: ");
            Console.Write("");
            double.TryParse(Console.ReadLine(), out operand2);

            if (operand2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Делить на ноль нельзя");
            }
            else
            {
                switch (sign)
                {
                    case "+":
                        Console.WriteLine($"{operand1 + operand2}");
                        break;
                    case "-":
                        Console.WriteLine($"{operand1 - operand2}");
                        break;
                    case "*":
                        Console.WriteLine($"{operand1 * operand2}");
                        break;
                    case "/":
                        Console.WriteLine($"{operand1 / operand2}");
                        break;
                    default:
                        Console.WriteLine("Такого арифметического знака нет");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}