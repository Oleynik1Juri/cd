using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte c = 4, d = 5;
            int difference = d - c;
            Console.WriteLine(difference);
           
            byte q = 7, w = 2;
            int summand = q + w;
            Console.WriteLine(summand);          
            
            byte r = 3, t = 14;
            int multiplication = r * t;
            Console.WriteLine(multiplication);
            
            byte s = 5, n = 10;
            int division = s / n, remainder = s % n;
            Console.WriteLine(division);
                                
            Console.ReadKey();
        }
    }
}