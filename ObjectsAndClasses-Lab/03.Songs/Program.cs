using System;
using System.Collections.Generic;

namespace _03.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOFSongs = int.Parse(Console.ReadLine());
            List<Song> data = new List<Song>();

            for (int i = 0; i < numberOFSongs; i++)
            {
                List<string> songs = new List<string>(Console.ReadLine().Split("_"));

                string typeSong = songs[0];
                string nameSong = songs[1];
                string timeSong = songs[2];

                Song song = new Song();

                song.TypeList = typeSong;
                song.Name = nameSong;
                song.Time = timeSong;

                data.Add(song);
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in data)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in data)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }

        }

        class Song
        {
            public string TypeList { get; set; }

            public string Name { get; set; }

            public string Time { get; set; }
        }
    }
}
