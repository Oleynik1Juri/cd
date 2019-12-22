using System.Runtime.InteropServices;

namespace Number_comparison.Model
{
     public class Calculator
     {
        public int Sum (int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
        public int Multiplications(int x, int y)
        {
            return x * y;
        }
        public int Division(int x, int y)
        {
            return x / y; 
        }

        public int Increment(int x)
        {
            return x++;
        }
        public int Decrement(int x)
        {
            return --x;
        }
       public double DecimalDivision(double x, double y)
       {
            return x / y;
       }

     }
}