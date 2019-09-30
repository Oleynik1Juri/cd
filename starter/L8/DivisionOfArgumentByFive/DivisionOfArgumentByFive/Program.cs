using System;

namespace DivisionOfArgumentByFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, numberb2, number3;
            Console.Write("Enter the first number:  ");
            int.TryParse(Console.ReadLine(), out number1);
            Console.Write("Enter the second number: ");
            int.TryParse(Console.ReadLine(), out numberb2);
            Console.Write("Enter the third number: ");
            int.TryParse(Console.ReadLine(), out number3);
            Calculate(number1, numberb2, number3);
        }

        static void Calculate(int number1, int numberb2, int number3)
        {
            if (number1%5==0)
            {
                Console.WriteLine($"First number={number1/5}"); 
            }
            else
            {
                Console.WriteLine("Error the first number is not divisible by 5"); 
            }

            if (numberb2%5==0)
            {
                Console.WriteLine($"Second number={numberb2/5}");
            }
            else
            {
                Console.WriteLine("Error the second number is not divisible by 5");
            }

            if (number3%5==0)
            {
                Console.WriteLine($"Third number={number3/5}");
            }
            else
            {
                Console.WriteLine("Error the third number is not divisible by 5");
            }
            
            Console.ReadKey();
        }
    }
}
        
