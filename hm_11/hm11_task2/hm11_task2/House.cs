using System;
using System.Collections.Generic;
using System.Text;

namespace hm11_task2
{
    class House
    {
        int area = 200;
       
        public void ShowData()
        {
            Console.WriteLine("Please enter house area");
            area = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"I am a house, my area is {area} m2");
        }
    }
    class Door
    {
        string color = "brown";
        public void ShowData()
        {
            Console.WriteLine("Please enter door color");
            color = Console.ReadLine();
            Console.WriteLine($"I am a door, my color is {color}");
        }
    }
    class SmallApartament : House
    {
        int area = 50; 
    }
}
