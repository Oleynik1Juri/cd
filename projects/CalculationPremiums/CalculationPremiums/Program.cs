using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationPremiums
{
    class Program
    {
        static void Main()
        {
            const int salary = 10000;
            Console.WriteLine("Введите стаж сотрудника: ");
            var experience = Convert.ToInt32(Console.ReadLine());
            
            if ((experience > 0) && (experience < 5))
            {
                Console.WriteLine("Премия сотрудника (10%): {0}", salary + (salary * 0.1));
            }
            else if ((experience >= 5) && (experience < 10))
            {
                Console.WriteLine("Премия сотрудника (15%): {0}", salary + (salary * 0.15));
            }
            else if ((experience >= 10) && (experience < 15))
            {
                Console.WriteLine("Премия сотрудника (25%): {0}", salary + (salary * 0.25));
            }
            else if ((experience >= 15) && (experience < 20))
            {
                Console.WriteLine("Премия сотрудника (35%): {0}", salary + (salary * 0.35));
            }
            else if ((experience >= 20) && (experience < 25))
            {
                Console.WriteLine("Премия сотрудника (45%): {0}", salary + (salary * 0.45));
            }
            else if (experience >= 25)
            {
                Console.WriteLine("Премия сотрудника (50%): {0}", salary + (salary * 0.50));
            }
            Console.ReadKey();
        }
    }
}
