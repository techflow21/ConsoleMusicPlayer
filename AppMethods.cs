
namespace ConsoleMusicPlayer
{
    partial class AppMethods
    {
        private static List<Playlist> playlists = new List<Playlist>();

        public static void ViewPlaylists()
        {
            if (playlists.Count == 0)
            {
                Console.WriteLine("\n\t No playlists found.");
                return;
            }

            foreach (var playlist in playlists)
            {
                Console.Write($"\n\t ID: {playlist.Id}\n\t Playlist Name: {playlist.Name}\n\t Songs: ");
                foreach (var song in playlist.Songs)
                {
                    Console.Write($"{song}, ");
                }
                Console.WriteLine();
            }
        }

        public static void CreatePlaylist()
        {
            Console.Write("\n\t Enter playlist name: \n\t ");
            string name = Console.ReadLine();
            Playlist playlist = new Playlist { Id = playlists.Count + 1, Name = name, Songs = new List<string>() };
            playlists.Add(playlist);
            Console.WriteLine("\n\t Playlist created successfully with ID: " + playlist.Id);
        }

        public static void AddSong()
        {
            Console.Write("\n\t Enter playlist ID: \n\t ");
            int id;
            int.TryParse(Console.ReadLine(), out id);
            var playlist = playlists.FirstOrDefault(p => p.Id == id);
            if (playlist == null)
            {
                Console.WriteLine("\n\t Invalid playlist ID. Please try again.\n");
                return;
            }

            Console.Write("\n\t Enter song name: \n\t ");
            string songName = Console.ReadLine();
            playlist.Songs.Add(songName);
            Console.WriteLine("\n\t Song added to playlist successfully.\n");
        }


        public static void DeletePlaylist()
        {
            Console.Write("\n\t Enter playlist ID: \n\t ");
            int id;
            int.TryParse(Console.ReadLine(), out id);
            var playlist = playlists.FirstOrDefault(p => p.Id == id);
            if (playlist == null)
            {
                Console.WriteLine("\n\t Invalid playlist ID. Please try again.\n");
                return;
            }
            playlists.Remove(playlist);
            Console.WriteLine("\n\t Playlist deleted successfully.\n");
        }

        public static void DeleteSong()
        {
            Console.Write("\n\t Enter playlist ID: \n\t ");
            int id;
            int.TryParse(Console.ReadLine(), out id);
            var playlist = playlists.FirstOrDefault(p => p.Id == id);
            if (playlist == null)
            {
                Console.WriteLine("\n\t Invalid playlist ID. Please try again.\n");
                return;
            }

            Console.Write("\n\t Enter song name: \n\t ");
            string songName = Console.ReadLine();
            if (!playlist.Songs.Remove(songName))
            {
                Console.WriteLine("\n\t Song not found in the playlist. Please try again.\n");
                return;
            }
            Console.WriteLine("\n\t Song deleted from playlist successfully.\n");
        }
    }
}
