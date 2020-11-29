using System;
using System.Linq;
using System.Diagnostics;

namespace hm_06_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            Stopwatch stopwatch1 = new Stopwatch();
            Console.WriteLine("Ваш массив:");
            int[] myArray = new int[1000000];
            for(int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            stopwatch.Start();
            Console.WriteLine("Реверс массива(Свой)");

            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }
            stopwatch.Stop();
            Console.WriteLine("Снова реверс(Метод Reverse)");
            stopwatch1.Start();
            myArray.Reverse();

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            stopwatch1.Stop();
            Console.WriteLine("Затрачено миллисекунд используя ручки:");
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            Console.WriteLine("Затрачено миллисекунд импользуя метод");
            Console.WriteLine(stopwatch1.ElapsedMilliseconds);
        }
    }
}
