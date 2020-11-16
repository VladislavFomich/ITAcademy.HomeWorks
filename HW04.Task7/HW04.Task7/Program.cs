using System;
using System.Globalization;

namespace HW04.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            Console.WriteLine("Нажитие W, A, S или D");
            do
            {
                char direction = Console.ReadKey().KeyChar;
          
                switch (direction)
                {
                    case 'w':
                    case 'W':
                        Console.WriteLine();
                        Console.WriteLine("Ваш персонаж двигается вперед");
                        break;

                    case 'a':
                    case 'A':
                        Console.WriteLine();
                        Console.WriteLine("Ваш персонаж двигается влево");
                        break;

                    case 's':
                    case 'S':
                        Console.WriteLine();
                        Console.WriteLine("Ваш персонаж двигается назад");
                        break;

                    case 'd':
                    case 'D':
                        Console.WriteLine();
                        Console.WriteLine("Ваш персонаж двигается вправо");
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Ваш персонаж стоит на месте");
                        break;
                }
            }
            while (a == 1);
        }
    }
}
