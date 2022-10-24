using System;
class HelloWorld
{
    static void Main(string[] args)
    {
        {
            while (true)
            {
                int n;
                bool k;
                while (true)
                {
                    try
                    {
                        Console.Write("Номер месяца:");
                        n = Convert.ToInt16(Console.ReadLine());
                        if (n >= 1 & n <= 12)
                        {
                            Console.Write("год високосный? Введите 0 если нет:");
                            k = Convert.ToBoolean(Console.Read());
                            break;
                        }
                        else
                            Console.WriteLine("Введите число от 1 до 12");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("не число");
                    }
                }
                switch (n)
                {
                    case 2:
                        if (k == true)
                            Console.WriteLine("в месяце 28 дней");
                        else
                            Console.WriteLine("в месяце 29 дней");
                        break;
                }
                switch (n)
                {
                    case 4:
                        Console.WriteLine("в месяце 30 дней");
                        break;
                    case 6:
                        Console.WriteLine("в месяце 30 дней");
                        break;
                    case 9:
                        Console.WriteLine("в месяце 30 дней");
                        break;
                    case 11:
                        Console.WriteLine("в месяце 30 дней");
                        break;
                    default:
                        Console.WriteLine("в месяце 31 дней");
                        break;
                }
                ConsoleKey e = Console.ReadKey().Key;
                if (e == ConsoleKey.Escape)
                    break;
                Console.WriteLine("нажата клавиша {0}", e);
            }
        }
    }
}