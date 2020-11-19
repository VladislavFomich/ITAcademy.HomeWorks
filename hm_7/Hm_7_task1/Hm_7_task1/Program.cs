using System;

namespace Hm_7_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стихотворение, отделяя строки символом \";\"");
            string str = Console.ReadLine();
            str = str.Replace('O', 'A'); 
            str = str.Replace('О', 'А');
            str = str.Replace('o', 'a');
            str = str.Replace('о', 'а');
            string[] words = str.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in words)
            {
                Console.WriteLine($"{s}");
            }
        }
    }
}