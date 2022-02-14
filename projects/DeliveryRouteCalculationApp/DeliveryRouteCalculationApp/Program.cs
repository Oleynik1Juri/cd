using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryRouteCalculationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Число клиентов: ");
            var customer = Convert.ToInt32(Console.ReadLine());

            var result = 1;

            do
            {
                result *= customer--;

            } while (customer > 0);

            Console.Write("Варианты доставки: {0}", result);
            Console.ReadKey();
        }
    }
}
