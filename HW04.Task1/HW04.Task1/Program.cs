using System;

namespace HW04.Task1
{
    class Program
    {
        static void Main(string[] args)
        { 
            inputYear:
            Console.WriteLine("Введите год рождения человека");
            int birthYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите текущий год");
            int nowYear = Convert.ToInt32(Console.ReadLine());

            if (birthYear > nowYear)
            {
                Console.WriteLine("Ошибка. Год рождения больше чем текущий год. Введите еще раз.");
                goto inputYear;
            }

        inputBirthMonth:
            Console.WriteLine("Введите номер месяца рождения человека");
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            if (birthMonth > 12 | birthMonth < 1)

            {
                Console.WriteLine("Вы ввели неверное значение месяца, введите еще раз");
                goto inputBirthMonth;
            }           

        inputNowMonth:
            Console.WriteLine("Введите номер текущего месяца");
            int nowMonth = Convert.ToInt32(Console.ReadLine());

            if (nowMonth > 12 | nowMonth < 1)
            {
                Console.WriteLine("Вы ввели неверное значение месяца, введите еще раз");
                goto inputNowMonth;
            }
   
            int yourAge = nowYear - birthYear;
           
            if (nowMonth < birthMonth)
            {
                yourAge = yourAge - 1;
            }
            Console.WriteLine($"Ваш возраст - {yourAge}");
        }
    }
}

        
    

