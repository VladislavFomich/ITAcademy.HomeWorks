using System;
using System.Text;
using System.Linq;
using System.Data;

namespace hm_08_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string input = Console.ReadLine();
            string strFirst = "";
            string str1 = "";
            string strSign = "";
            int result = 0;
            string lastStr = "";

            for (int i = 0; i < input.Length-1 & input[i] != '*' & input[i] != '/' & input[i] != '+' & input[i] != '-'; i++)
            {
                if(char.IsNumber(input[i]))
                {
                    strFirst = strFirst + input[i];
                }
            }

            for (int i = input.Length - 1;input[i] != '*' & input[i] != '/' & input[i] != '+' & input[i] != '-'; i--)
            {
                if (char.IsNumber(input[i]))
                {
                    str1 = str1 + input[i];
                }

            }

            for (int i = 0; i < input.Length -1; i++)
            {
                if (input[i] == '*' | input[i] == '/' | input[i] == '+' | input[i] == '-')
                {
                    strSign = strSign + input[i];
                }
            }

            string strSecond = new string(str1.ToCharArray().Reverse().ToArray());
            lastStr = strFirst + strSign + strSecond;
            result = Convert.ToInt32(new DataTable().Compute(lastStr, null));
            Console.WriteLine(result);
        }
    }
}
