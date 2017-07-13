using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string, string)> goodSongs = new List<(string, string)>();
            HashSet<(string artist, string song)> allSongs = new HashSet<(string artist, string song)>();
            allSongs.Add(("Nickelback", "How You Remind Me"));
            allSongs.Add(("Drake", "Hello"));
            allSongs.Add(("50 cent", "By By"));
            allSongs.Add(("Pac", "Hit them up"));
            allSongs.Add(("Britney", "Airplane"));
            allSongs.Add(("Rock", "How You Remind Me"));
            allSongs.Add(("Nickelback", "How You Forget Me"));

            foreach (var item in allSongs)
            {
                if (item.Item1 != "Nickelback")
                {
                    goodSongs.Add(item);
                }
            }
            foreach (var item in goodSongs)
            {
                Console.WriteLine($"{item.Item2} by {item.Item1}");
            }
        }
    }
}
