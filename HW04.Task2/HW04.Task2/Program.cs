using System;
using System.Diagnostics.CodeAnalysis;

namespace HW04.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator();
            MathCheck();
            MathCheck2();
        }

        static void Calculator()
        {
            Console.WriteLine("Введите первое число");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine($"Суммв введенных чисел = {sum}");
        }

        static void MathCheck()
        {
            Console.WriteLine("Введите первое число");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите сумму чисел");
            int inputSum = Convert.ToInt32(Console.ReadLine());

            int realSum = num1 + num2;

            if (inputSum == realSum)
            {
                Console.WriteLine("Правильно");
            }
            else
            {
                Console.WriteLine("Неправильно");
            }

          
            }
        static void MathCheck2()
        {
            Console.WriteLine("Введите первое число");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите сумму чисел");
            int inputSum = Convert.ToInt32(Console.ReadLine());

            int realSum = num1 + num2;

            if (inputSum == realSum)
            {
                Console.WriteLine("Правильно");
            }
            else if (inputSum > realSum)
            {
                Console.WriteLine("Должно быть меньше");
            }
            else if (inputSum < realSum)
            {
                Console.WriteLine("Должно быть больше");
            }
            else
            {
                Console.WriteLine("Неправильно");
            }

        }
    }
}
