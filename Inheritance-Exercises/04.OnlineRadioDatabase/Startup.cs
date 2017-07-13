namespace _04.OnlineRadioDatabase
{
    using System;

    using _04.OnlineRadioDatabase.Models;

    class Startup
    {
        static void Main()
        {
            var radio = new Radio();
            var numberOfSongs = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfSongs; i++)
            {
                try
                {
                    var songArgs = Console.ReadLine().Split(new []{';'}, StringSplitOptions.RemoveEmptyEntries);
                    var song = new Song(songArgs[0], songArgs[1], songArgs[2]);

                    radio.AddSong(song);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine(radio);
        }
    }
}
