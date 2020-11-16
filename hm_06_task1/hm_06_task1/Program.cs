using System;

namespace hm_06_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массивов - ");
            int arrayElement = Convert.ToInt32(Console.ReadLine());
            int[] firstArray = new int[arrayElement];
            int[] secondArray = new int[arrayElement];
            int[] thirdArray = new int[arrayElement];
            Random rnd = new Random();

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write($"Введите значения элемента массива под номером {i+1} - ");
                firstArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < secondArray.Length; i++)
                secondArray[i] = rnd.Next();

            Console.Write("\nПервый массив (Введенный пользователем) - ");
            for (int i = 0; i < firstArray.Length; i++)
                Console.Write($"{firstArray[i]}; ");

            Console.Write("\nВторой массив (Случайные цифры) - ");
            for (int i = 0; i < secondArray.Length; i++)
                Console.Write($"{secondArray[i]}; ");

            Console.Write("\nТретий массив (Сумма первых двух) -");
            for (int i = 0; i < secondArray.Length; i++)
            {
                thirdArray[i] = firstArray[i] + secondArray[i];
                Console.Write($"{thirdArray[i]}; ");
            }
        }
    }
}
