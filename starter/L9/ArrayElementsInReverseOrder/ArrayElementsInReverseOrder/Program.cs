using System;

namespace ArrayElementsInReverseOrder
{
    class Program
    {
        static void Main()
        {

            var array = SsArray(10);
            Display(array);
            Console.WriteLine("-----------------");
            var invert = InArray(array);
            Display(invert);
            Console.ReadKey();

        }

        static int[] SsArray(int n)
        {
            var array = new int[n];

            for (var i = 0; i < n; i++)
            {
                array[i] = i;

            }

            return array;
        }

        static void Display(int[] array)
        {
            for (int d = 0; d < array.Length; d++)
            {
                Console.WriteLine(array[d]);
            }

        }

        static int[] InArray(int[] array)
        {
            var n = array.Length;
            var InArray = new int[n];

            for (var i = 0; i < array.Length; i++)
            {
                InArray[i] = array[n - 1];
                n--;
                
            }
            
            return InArray;
        }
    }
}