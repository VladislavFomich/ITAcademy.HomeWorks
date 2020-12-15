using System;
using System.Text.Json;

namespace hm_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song();
            Console.WriteLine("Введите имя песни:");
            song.name = Console.ReadLine();
            Console.WriteLine("Введите длинну песни:");
            song.Lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год песни:");
            song.Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите автора песни:");
            song.composer = Console.ReadLine();
            Console.WriteLine("Выберите жанр: 1 - Rock, 2 - Funk, 3 - Jazz, 4 - Classical, 5 - Rap, 6 - Reggie.");
            string num = Console.ReadLine();

            switch (num)
            {
                case "1":
                    song.genre = Song.Genres.Rock;
                    break;
                case "2":
                    song.genre = Song.Genres.Funk;
                    break;
                case "3":
                    song.genre = Song.Genres.Jazz;
                    break;
                case "4":
                    song.genre = Song.Genres.Classical;
                    break;
                case "5":
                    song.genre = Song.Genres.Rap;
                    break;
                case "6":
                    song.genre = Song.Genres.Reggie;
                    break;
                default:
                    Console.WriteLine("Введено неверное число, введите данные заново.");
                    break;                    
            }
            song.GetSongData(song);
            
        }
    }
}
