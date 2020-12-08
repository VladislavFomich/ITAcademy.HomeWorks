using System;
using System.Collections.Generic;
using System.Text;

namespace hm11_task2
{
    class Person
    {
      public  string name;
       public void ShowData()
        {
            Console.WriteLine($"My name is {name}");
            House house = new House();
            house.ShowData();

            Door door = new Door();
            door.ShowData();
        }
    }
}
