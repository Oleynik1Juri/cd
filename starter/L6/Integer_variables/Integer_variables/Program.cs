using System;
using System.Runtime.Serialization.Formatters;

namespace Integer_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                for (int a = 0; a < 7; a++)
                {
                   for (int b = 0; b < a; b++)
                   {
                        Console.Write("*");
                   }
                   Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
}

