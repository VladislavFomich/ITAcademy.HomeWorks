using System;
using System.Linq;

namespace Hm_7_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку -");
            string input = Console.ReadLine();

            DeliteTask(input);
            ReplacmentTask(input);
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
            int maxposition = 0;
            int minPosition = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxLenght)
                {
                    maxLenght = str[i].Length;
                    maxposition = i;
                }
                else
                {
                    maxLenght = str[i].Length;
                    minPosition = i;
                }
            }
            (str[maxposition], str[minPosition]) = (str[minPosition], str[maxposition]);
            
            string str2 = string.Join(' ', str);
            Console.WriteLine($"Поменяли местами самое длинное слово и самое короткое - {str2}");
            
        }
    }
}
