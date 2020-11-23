using System;
using System.Text;

namespace hm_8_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("1a!2.3!!..4.!.?6 7! ..?");

            for (int i = 16; i <= '?'; i++)
                sb.Replace(' ', '_');

            sb.Remove(2, 1);
            sb.Remove(5, 2);
            sb.Remove(9, 1);
            Console.WriteLine(sb);
        }
    }
}
