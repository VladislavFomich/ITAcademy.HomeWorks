using Microsoft.CSharp.RuntimeBinder;
using System;

namespace HW04.Task6
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 90; i > 64; i--)
            {
                char letter = Convert.ToChar(i);
                Console.Write(letter);
            }

        }
    }
}
