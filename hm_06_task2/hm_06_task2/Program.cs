using System;

namespace hm_06_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массивов - ");
            int arrayElement = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[arrayElement];
            int elementValue = 0;
            int elementPosition = 0;
            int[] myArray2 = new int[arrayElement];
            
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                Console.Write($"Введите значения элемента массива под номером {i + 1} - ");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Ваш массив - ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine("Введите значение оставшегося элемента ");
            elementValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите индекс элемента массива ");
            elementPosition = Convert.ToInt32(Console.ReadLine());

            int elementPosition2 = elementPosition + 1;
            int countElement = arrayElement - elementPosition - 1;
            Array.Copy(myArray, elementPosition, myArray2, elementPosition2, countElement);
            myArray2[elementPosition] = elementValue;

            Console.WriteLine("Ваш новый массив: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"\n{myArray2[i]}");
            }
        }
    }
}
