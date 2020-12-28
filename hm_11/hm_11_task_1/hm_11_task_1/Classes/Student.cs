using System;
using System.Collections.Generic;
using System.Text;

namespace hm_11_task_1
{
    class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class");
        }
        public void ShowAge()
        {
            Console.WriteLine($"My age is: {n} years old");          
        }
    }
}
