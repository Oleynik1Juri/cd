namespace EmptyAppConditionalConstructions
{
    class Program
    {
        static void Main(string[] args)

        {
            string word;
            System.Console.WriteLine("Добро пожаловать в русско-английский переводчик");
            do
            {
                System.Console.ForegroundColor = System.ConsoleColor.White;
                System.Console.WriteLine("Введите русское слово: ");
                word = System.Console.ReadLine();
                switch (word)
                {
                    case "небо":
                        {
                            System.Console.WriteLine("Sky");
                            break;
                        }
                    case "снег":
                        {
                            System.Console.WriteLine("Snow");
                            break;
                        }
                    case "туман":
                        {
                            System.Console.WriteLine("fog");
                            break;
                        }
                    case "осадки":
                        {
                            System.Console.WriteLine("rainfall");
                            break;
                        }
                    case "дождь":
                        {
                            System.Console.WriteLine("rain");
                            break;
                        }
                    case "ливень":
                        {
                            System.Console.WriteLine("shower");
                            break;
                        }
                    case "холодный":
                        {
                            System.Console.WriteLine("chilly");
                            break;
                        }
                    case "моросит":
                        {
                            System.Console.WriteLine("drizzle");
                            break;
                        }
                    case "ураган":
                        {
                            System.Console.WriteLine("hurricane");
                            break;
                        }
                    case "молния":
                        {
                            System.Console.WriteLine("lightning");
                            break;
                        }
                    default:
                        {
                            System.Console.ForegroundColor = System.ConsoleColor.Green;
                            System.Console.WriteLine("Вы ввели слово которого переводчик не знает");
                            break;
                        }
                }

            } while (word != "exit");

        }
    }
}