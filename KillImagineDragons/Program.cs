using System;
using System.Collections.Generic;
using System.Linq;

namespace KillImagineDragons
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodSongs = new List<Song>();
            var allSongs = new List<Song>()
            {
                new Song("Imagine Dragons", "Bleeding Out"),
                new Song("Imagine Dragons","Whatever It Takes"),
                new Song("Build To Spill", "Goin' Against Your Mind"),
                new Song("ScHoolboy Q", "THat Part"),
                new Song("Pixies", "Tame"),
                new Song("Kendrick Lamar", "For Free?"),
                new Song("Jay Reatard", "Blood Vision"),
                new Song("Imagine Dragons","It's Time"),
                new Song("Tame Impala", "Let It Happen"),
                new Song("The Walkmen", "The Rat"),
                new Song("Nine Inch Nails","March of the Pigs"),
                new Song("Outkast","SpottieOttieDopaliscious")
            };
            goodSongs.AddRange(allSongs.Where(Song => Song.Artist != "Imagine Dragons"));
            foreach(var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist} : {song.Name}");
            }
        }
    }
}
