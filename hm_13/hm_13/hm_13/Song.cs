using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace hm_13
{
    class Song
    {
       public Genres genre;
       public string name;   
       private int lenght;
        public int Lenght
        {
            get { return lenght; }
            set
            {
                if(value >= 0 && value < 1000)
                lenght = value;
            }
        }
        public string composer;
        private int year;
        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 0 && value < 2020)
                    year = value;
            }
        }

        public enum Genres
        {
            Rock,
            Funk,
            Jazz,
            Classical,
            Rap,
            Reggie
        }

        public void GetSongData(Song song)
        {
            var song1 = new
            {
                name = song.name,
                Lenght = song.Lenght,
                Year = song.Year,
                composer = song.composer,
                genre = song.genre
            };
            Console.WriteLine($"Название песни: {song1.name}, автор песни: {song1.composer}, длинна песни (секунд): {song1.Lenght}, год песни: {song1.Year}, жанр песни: {song1.genre}.");
            string json = JsonSerializer.Serialize(song1);
            Console.WriteLine(json);
        }
        
    }  
}
