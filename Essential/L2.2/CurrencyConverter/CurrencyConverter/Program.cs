using System;
using CurrencyConverter.Model;

namespace CurrencyConverter
{
    class Program
    {
        static void Main()
        {
          
            Converter converter = new Converter(23, 30, 0.39);
            Console.WriteLine($"23 UAN converter in USA :{converter.ConverterUA_v_USD(23)}");
            Console.WriteLine($"30 UAH convert in EUR :{converter.ConverterUA_v_EUR(30)}");
            Console.WriteLine($"1000 RUB convert in UAN :{converter.ConverterUA_v_RUB(1000)}");
            
            Console.ReadKey();
        }
	}
}