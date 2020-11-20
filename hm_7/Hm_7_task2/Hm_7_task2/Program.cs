using System;
using System.Linq;

namespace Hm_7_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку - ");
            string input = Console.ReadLine();

            DeliteTask(input);
            ReplacmentTask(input);
            CountTask(input);
            SortingTask(input);
        }

        static void DeliteTask(string input)
        {
            string[] str = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int maxLenght = 0;
            int position = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxLenght)
                {
                    maxLenght = str[i].Length;
                    position = i;
                }           
            }
            str[position] = "";
            string str2 = string.Join(' ', str);
            Console.WriteLine($"Ваша строка без самого длинного слова - {str2}");
        }
        static void ReplacmentTask(string input)
        {
            string[] str = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int maxLenght = 0;
            int maxPosition = 0;
            int minPosition = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxLenght)
                {
                    maxLenght = str[i].Length;
                    maxPosition = i;
                }
                else
                {
                    maxLenght = str[i].Length;
                    minPosition = i;
                }
            }
            (str[maxPosition], str[minPosition]) = (str[minPosition], str[maxPosition]);
            
            string str2 = string.Join(' ', str);
            Console.WriteLine($"Поменяли местами самое длинное слово и самое короткое - {str2}");
            
        }
        static void CountTask(string input)
        {
            int letterCount = 0;
            int punctuationCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                    letterCount++;
                else if (char.IsPunctuation(input[i]))
                {
                    punctuationCount++;
                }             
            }
            Console.WriteLine($"Количество букв в строке = {letterCount}");
            Console.WriteLine($"Количество знаков препинания в строке = {punctuationCount}");
        }
        static void SortingTask(string input)
        {
            string[] str = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
           
            Array.Sort(str);
            Array.Reverse(str);
            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < str.Length; i++)
                Console.WriteLine(str[i]);
            
        }
    }
}
