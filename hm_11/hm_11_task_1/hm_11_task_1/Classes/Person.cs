using System;
using System.Collections.Generic;
using System.Text;

namespace hm_11_task_1
{
    public class Person
    {
       public int n;
        public void SetAge()
        {
            Console.WriteLine("Please set age:");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public void Greeting()
        {
            Console.WriteLine("Hello!");
        }
    }
}
