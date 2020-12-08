using System;

namespace hm11_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallApartament smallApartament = new SmallApartament();
            Person person = new Person();
            person.name = "Bob";
            person.ShowData();
        }
    }
}
