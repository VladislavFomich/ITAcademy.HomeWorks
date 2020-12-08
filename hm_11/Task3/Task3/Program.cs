using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Films film = new Films();
            film.name = "Pirates of Carribean";
            film.category = "Action";
            film.size = 250;
            film.producer = "Jerry Bruckhaimer";
            film.mainActor = "Johny Depp";
            film.mainActress = "Kira Naitli";
            film.Play();
            film.RetrieveInformation();

            Music music = new Music();
            music.name = "Bad Guy";
            music.category = "Pop";
            music.size = 15;
            music.performer = "Billie Eillish";
            music.lenght = 300;
            music.Play();
            music.RetrieveInformation();
        }
    }
}
