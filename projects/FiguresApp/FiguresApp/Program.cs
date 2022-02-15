using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 10; i++)
            {
                for (var j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (var a = 0; a < 10; a++)
            {
                for (var b = 0; b < a; b++)
                {
                    Console.Write("@");
                }
                Console.WriteLine("");
            }





            Console.ReadKey();

        }
    }
}
