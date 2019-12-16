using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_comparison.Model
{
     public class Number
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
        public int DivisionByZero(int x, int y)
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
        public object DecimalDivision(double x, double y)
        {
            return x / y;
        }
     }

}