using System;
using System.Text;

namespace hm_8_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("1a!2.3!!.. 4.!.?6 7! ..?");         
            sb.Remove(2, 1);
            sb.Remove(5, 2);
            sb.Remove(10, 1);

            for (int i = 12; i < sb.Length-1; i++)
            {
                if (sb[i] == ' ')
                    sb[i] = '_';
            }
            Console.WriteLine(sb);
        }
    }
}
