using System;
using System.Diagnostics.CodeAnalysis;

namespace HW04.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task2();
            Task3();
            Task4();
            Task5();
        }



          static void Task2()
          { 
               Console.WriteLine("Введите первое число");
               int num1 = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine("Введите второе число");
               int num2 = Convert.ToInt32(Console.ReadLine());

               int sum = num1 + num2;
               Console.WriteLine($"Суммв введенных чисел = {sum}");
          }



           static void Task3()
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



           static void Task4()
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

               if (inputSum > realSum)
               {
                   Console.WriteLine("Должно быть меньше");
               }
               else if (inputSum < realSum)
               {
                   Console.WriteLine("Должно быть больше");
               }
           }



        static void Task5()
        {
            Console.WriteLine("Введите первое число");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите оператор + или -");
            char inputOp = Convert.ToChar(Console.ReadLine());

            int realSum;

            if (inputOp == '+')
            {
                realSum = num1 + num2;
            }
            else if (inputOp == '-')
            {
                realSum = num1 - num2;
            }
            else
            {
                Console.WriteLine("Вы ввелм неверный оператор");
                realSum = 0;
                Environment.Exit(0);
            }

            Console.WriteLine("Введите результат операции");
            int inputSum = Convert.ToInt32(Console.ReadLine());
                 
            if (inputSum == realSum)
            {
                Console.WriteLine("Правильно");
            }
            else
            {
                Console.WriteLine("Неправильно");
            }
            
            if (inputSum > realSum)
            {
                Console.WriteLine("Должно быть меньше");
            }
            else if (inputSum < realSum)
            {
                Console.WriteLine("Должно быть больше");
            }          
        }
    }  
}
