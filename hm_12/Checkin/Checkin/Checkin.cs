using System;
using System.Collections.Generic;
using System.Text;

namespace Checkin
{
  abstract class Checkin
    {
        public static string Name;
        public static string Passport;
        public static int TicketNum;
        public static string Adress;  
    }

    class Registration : Checkin
    {
        
        
        public void Greeting()
        {
            string nowTime = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(nowTime);

            int nowHours = Convert.ToInt32(DateTime.Now.ToString("HH"));

            if (nowHours > 8 && nowHours < 13)
                Console.WriteLine("Доброе утро!");

            else if (nowHours > 12 && nowHours < 16)
               Console.WriteLine("Добрый день!");

            else if (nowHours > 15 && nowHours < 23)
                Console.WriteLine("Добрый Вечер!");

            else
                Console.WriteLine("Доброй ночи!");

            Console.WriteLine("Вас приветствует аэропорт Домодедово. Приступаем к регистрации.");
        }

        public void Adressname()
        {
            Console.WriteLine("Назовите свое имя:");
            Name = Console.ReadLine();
            Console.WriteLine($"Вы зарегестрированы под именем {Name}.");
            Console.WriteLine("Укажите ваш пол:");
            Console.WriteLine("1 - мужской, 2 - женский.");
            string adressnameSelection = Console.ReadLine();
            switch (adressnameSelection)
            {
                case "1":
                    Console.WriteLine($"{Name}, вы выбрали мужской пол.");
                    Adress = "Сэр";
                    break;
                case "2":
                    Console.WriteLine($"{Name}, вы выбрали женский пол.");
                    Adress = "Мэм";
                    break;
                default:
                    Console.WriteLine("Вы ввели неправельный пункт, по дефолту будете мужского пола.");
                    goto case "1";
            }
        }
        public void Process()
        {
            Console.WriteLine("Регистрировались ли вы раньше? Если Да, нажмите 1. Если Нет, то 2.");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    Console.WriteLine($"{Adress}, нам нужно подтвердить данные.");
                    break;
                case "2":
                    Console.WriteLine($"{Adress}, давайте зарегистрируемся.");
                    break;
                default:
                    Console.WriteLine("Вы указали неверную пункт.");
                    goto case "2";
            }
            Console.WriteLine("Введите паспортные данные (серия и номер):");
            Passport = Console.ReadLine();
            Console.WriteLine("Укажите количество билетов: ");
            TicketNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Спасибо, переходите на досмотр.");
        }
    }

    class Inspection : Checkin
    {
        public void Inspector()
        {
            Console.WriteLine($"Здравствуйте {Name}, перевозите запретные вещества или оружие?");
            Console.WriteLine("1 - Да, 2 - Нет.");
            string inspectorSelection = Console.ReadLine();
            switch (inspectorSelection)
            {
                case "1":
                    Console.WriteLine($"Ничего {Adress}, мы самый лучший аэропорт, проходите на Паспортный контроль.");
                    break;
                case "2":
                    Console.WriteLine($"Отлично {Adress}, проходите на Паспортный контроль.");
                    break;
                default:
                    Console.WriteLine("Вы ввели неправельный пункт.");
                    goto case "1";
            }

        }
    }

    class PassportControl : Checkin
    {
        public void Over()
        {
            Console.WriteLine($"{Adress}, эти данные верны?");
            Console.WriteLine($"Имя - {Name}, Паспортные данные - {Passport}, Количество билетов - {TicketNum}");
            Console.WriteLine("1 - Да, 2 - Нет.");
            string overSelection = Console.ReadLine();
            switch (overSelection)
            {
                case "1":
                    Console.WriteLine($"{Adress}, проходите на посадку.");
                    break;
                case "2":
                    Console.WriteLine($"{Adress}, придется повторить все процедуры.");
                    break;
                default:
                    Console.WriteLine("Вы ввели неправельный пункт.");
                    goto case "2";
            }
        }
        
    }
}
