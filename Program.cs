namespace Pract_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            while (a != 0)
            {
                Console.WriteLine("Выберите действие от 1 до 3");
                Console.WriteLine("1 - Угадай число");
                Console.WriteLine("2 - Таблица умножения");
                Console.WriteLine("3 - Вывод делителей числа");
                Console.WriteLine("4 - Выход");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    Game();
                }
                else if (a == 2)
                {
                    Game1();
                }
                else if (a == 3)
                {
                    Game2();
                }
                else if (a == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Вы вышли из программы");
                }
        static void Game()
                {
                    Console.WriteLine("Угадай число от 1 до 100");
                    bool b = true;
                    Random r = new Random();
                    int Value = r.Next(0, 100);
                    while (b)
                    {
                        int a = Convert.ToInt32(Console.ReadLine());
                        if (a != Value)
                        {
                            Console.WriteLine("Вы ввели неправильное число");
                        }
                        else
                        {
                            Console.WriteLine("Вы угадали");
                            b = false;
                        }
                    }
                }
        static void Game1()
                {
                    int[,] tablica = new int[1, 9];
                    for (int z = 1; z < 10; z++)
                    {
                        for (int x = 1; x < 10; x++)
                        {
                            Console.Write("{0}\t", z * x);
                        }
                    }
                }
        static void Game2()
                {
                    int c = 0;
                    Console.WriteLine("Введите целое число");
                    c = Convert.ToInt32(Console.ReadLine());
                    for (int y = 0; y < y + 1; y++)
                    {
                        if (c % y == 0)
                        {
                            Console.WriteLine(y);
                        }
                        else
                        {
                            Console.WriteLine(c);
                        }
                    }
                }
            }
        }
    }
}