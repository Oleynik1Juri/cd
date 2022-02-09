using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation_of_volume_and_surface_area_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Объем V цилиндра");
            Console.Write("r = ");
            int.TryParse(Console.ReadLine(), out var r);
            Console.Write("h = ");
            int.TryParse(Console.ReadLine(), out var h);
            var v = Math.PI * Math.Pow(r, 2) * h;
            Console.WriteLine($"Результат = {v}");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Площадь S поверхности цилиндра");
            var s = 2 * Math.PI * r * (r + h);
            Console.WriteLine($"Результат = {s}");
            
            Console.ReadKey();


        }
    }
}
