using System;
namespace Computing_Integer_Arguments_v._7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("First number - ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("Second number - ");
            int.TryParse(Console.ReadLine(), out b);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Third number - ");
            int.TryParse(Console.ReadLine(), out c);
            Console.ForegroundColor = ConsoleColor.Green;
            Calculate(a, b, c);
        }

        static void Calculate(int a, int b, int c)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Arithmetic mean of argument values: = " + ((a + b + c) / 3).ToString());
            Console.ReadKey();
        }
    }
}
