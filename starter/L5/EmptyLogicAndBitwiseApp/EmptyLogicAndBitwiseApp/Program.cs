namespace EmptyLogicAndBitwiseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // [1;2;4;8;16;32]
            {
                int doubleExpo = 0;
                System.Console.WriteLine("Введите число для проверки!");
                int one_bit = System.Convert.ToInt32(System.Console.ReadLine());
                doubleExpo = one_bit & (one_bit - 1);
                if (doubleExpo == 0)
                {
                    System.Console.WriteLine("Число - степень двойки!");
                }
                else
                {
                    System.Console.WriteLine("Число - не степень двойки!");
                }
                System.Console.ReadKey();
            }
        }
    }
}
          