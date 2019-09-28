using System;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.ForegroundColor = System.ConsoleColor.Green; // пом. цвет
            Console.Write("First number - "); // ввод значения
            a = Convert.ToInt32(Console.ReadLine()); // конвек. бук. в цыфры
            Console.Write("Second number - "); // ввод значения
            b = Convert.ToInt32(Console.ReadLine()); // конвек. бук. в цыфры
            Console.ForegroundColor = System.ConsoleColor.Green; // пом. цвет
            Console.Write("Third number - "); // ввод значения
            c = Convert.ToInt32(Console.ReadLine()); // конвек. бук. в цыфры
            Console.ForegroundColor = System.ConsoleColor.Green; // пом. цвет
            Calculate(a, b, c); // вызов метода Calculate
        }
        static void Calculate(int a, int b, int c)  // новый метод,  который принимает в качестве параметров три целочисленных аргумента.
        {
            Console.ForegroundColor = System.ConsoleColor.Red; // пом. цвет
            Console.WriteLine("Arithmetic mean of argument values: = " + ((a + b + c) / 3).ToString()); // выводит на экран среднее арифметическое значений аргументов 
            Console.ReadKey();
        }
    }
}
