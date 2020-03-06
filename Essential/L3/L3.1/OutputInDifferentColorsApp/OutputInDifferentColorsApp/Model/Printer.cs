using System;

namespace OutputInDifferentColorsApp.Model
{
    internal class Printer
    {
        private readonly ConsoleColor _color;

        public Printer(ConsoleColor color)
        {
            _color = color;
        }

        public void Print(string value)
        {
            Console.ForegroundColor = _color;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}