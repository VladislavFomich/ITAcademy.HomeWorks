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

            Console.WriteLine("Введите позицию в массиве оставшегося элемента ");
            elementPosition = Convert.ToInt32(Console.ReadLine());
            elementPosition = elementPosition - 1;

                for (int i = 0; i < myArray.Length;i++)
            {
                if (elementPosition >= i)
                {
                    int ase = myArray[i + 1];
                    myArray[i] = ase;
                }
            }
            myArray[elementPosition] = elementValue;

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"\n{myArray[i]}");
            }
        }
    }
}
