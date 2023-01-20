

namespace ConsoleMusicPlayer
{
    partial class AppMethods
    {
        public static void ViewAllSongsAlphabetical()
        {
            if (playlists.Count == 0)
            {
                Console.WriteLine("\n\t No playlists found.\n");
                return;
            }

            var allSongs = playlists.SelectMany(p => p.Songs).OrderBy(s => s);
            Console.WriteLine("\n\t All songs in alphabetical order:\n");
            foreach (var song in allSongs)
            {
                Console.WriteLine(song);
            }
        }

        public static void ViewAllSongsRandom()
        {
            if (playlists.Count == 0)
            {
                Console.WriteLine("\n\t No playlists found.\n");
                return;
            }

            var allSongs = playlists.SelectMany(p => p.Songs).OrderBy(s => Guid.NewGuid());
            Console.WriteLine("\n\t All songs in random order:\n");
            foreach (var song in allSongs)
            {
                Console.WriteLine($"\t {song}\n");
            }
        }
    }
}
