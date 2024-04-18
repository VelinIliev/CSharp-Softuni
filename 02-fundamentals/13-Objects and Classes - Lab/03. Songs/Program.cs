using System.Numerics;
using System;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> listOfSongs = new List<Song>();
            
            int songsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < songsNumber; i++)
            {
                string[] input = Console.ReadLine().Split("_").ToArray();
                string typeList = input[0];
                string name = input[1];
                string time = input[2];

                Song newSong = new Song();
                
                newSong.typeList = typeList;
                newSong.name = name;
                newSong.time = time;
                
                listOfSongs.Add(newSong);
            }

            string filter = Console.ReadLine();

            if (filter == "all")
            {
                foreach (Song song in listOfSongs)
                {
                    Console.WriteLine(song.name);
                }
            }
            else
            {
                List<Song> filteredSongs = listOfSongs.Where(x => x.typeList == filter).ToList();
                foreach (Song song in filteredSongs)
                {
                    Console.WriteLine(song.name);
                }
            }
        } 
        
        public class Song
        {
            public string typeList { get; set; }
            public string name { get; set; }
            public string time { get; set; }
        }
    }
}