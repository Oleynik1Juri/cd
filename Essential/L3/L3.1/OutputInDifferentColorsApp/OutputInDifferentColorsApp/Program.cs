using System;
using OutputInDifferentColorsApp.Model;

namespace OutputInDifferentColorsApp
{
    internal class Program
    {
        private static void Main()
        {
            var print = new PPrintCol(ConsoleColor.Blue);
            print.Print("Color Blue");

            var printG = new PPrintCol(ConsoleColor.Yellow);
            printG.Print("Color Yellow");

            Printer printer = print;
            printer.Print("Color Blue");

            Console.ReadKey();
        }

    }
}