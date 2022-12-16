using System.Text.RegularExpressions;

namespace ConsoleMusicPlayer
{
    internal class Operations
    {
        static string inputPattern = @"[a-zA-Z0-9]{2,20}";
        static Regex regex = new(inputPattern);

        // Create a list of playlists
        public static List<Playlist> playlists = new List<Playlist>();

        // Create two playlists 
        static Playlist PopSongs = new Playlist("Pop Songs");

        public static void DefaultPlaylistWithSongs()
        {
            // Add songs to each playlist
            PopSongs.AddSong("Shape of You");
            PopSongs.AddSong("Cheap Thrills");
            PopSongs.AddSong("Uptown Girls");

            // Add playlists to the list
            playlists.Add(PopSongs);
        }

        // Method to view all available playlists with their songs
        public static void ViewPlaylists()
        {
            Console.WriteLine("\t Available Playlists with their songs: \n\t======================================\n");

            foreach (var playlist in playlists)
            {
                Console.WriteLine($"\t Playlist: {playlist.Name}\n\t------------------------------------------");

                foreach (var song in playlist.Songs)
                {
                    Console.WriteLine($"\n\t   {song}\n");
                }
            }

            Utility.ContinueMessage();
        }

        // Method to create new playlist by accepting playlist name from an input and add to the list of playlist.
        public static void CreatePlaylist()
        {
            Console.Write("\t Enter the name of the new playlist you would like to create: \n\t ");
            string playlistName = Console.ReadLine();

            if (playlistName == null || !regex.IsMatch(playlistName))
            {
                Console.WriteLine("You entered invalid playlist name! try again");
                CreatePlaylist();
            }

            Playlist newPlaylist = new Playlist(playlistName);
            playlists.Add(newPlaylist);
            Console.WriteLine("\n\t Playlist has been created successfully!");

            Utility.ContinueMessage();
        }

        // Method to delete playlist by accepting playlist Id from an input
        public static void DeletePlaylist(string name)
        {
            Console.WriteLine($"\t Available Playlists\n\t-----------------------------\n");

            foreach (var playlist in playlists)
            {
                Console.WriteLine($"\t Playlist: {playlist.Name}\n");
            }

            Console.Write("\n\n\t Enter the name of the playlist to delete: \n\n\t ");

            var playlistName = Console.ReadLine();

            Playlist playlistToDelete = null;

            foreach (Playlist playlist in playlists)
            {
                if (playlist.Name == playlistName)
                {
                    playlistToDelete = playlist;
                }
            }

            if (playlistToDelete != null)
            {
                playlists.Remove(playlistToDelete);
                Console.WriteLine("Playlist {0} deleted!", playlistName);
                Utility.ContinueMessage();
            }

            else
            {
                Console.WriteLine("Playlist {0} not found!", playlistName);
                DeletePlaylist(playlistName);
            }
        }

        // Method to add songs by accepting song name
        public static void AddSong(string songName)
        {
            Console.Write("\n\t Enter the name of the playlist you would like to add a song to: \n\t");
            string playlistName = Console.ReadLine();

            Console.Write("\n\t Enter the name of the song you would like to add: \n\t ");
            songName = Console.ReadLine();

            foreach (var playlist in playlists)
            {
                if (playlist.Name != playlistName)
                {
                    Console.WriteLine($"\n\t An error occurred, try again");
                    AddSong(songName);
                }
                else
                {
                    playlist.AddSong(songName);
                    Console.WriteLine("\n\t Song has been added successfully!");
                    Utility.ContinueOption();
                } 
            }

            Utility.ContinueMessage();
        }


        // Method to delete song by accepting song name from an input
        public static void DeleteSong()
        {
            Console.WriteLine("\n\t Enter the name of the song you would like to delete: ");
            string songName = Console.ReadLine();

            foreach (var playlist in playlists)
            {
                for (int i = 0; i < playlist.Songs.Count; i++)
                {
                    if (playlist.Songs[i] == songName)
                    {
                        playlist.Songs.RemoveAt(i);
                        Console.WriteLine("\n\t Song has been deleted successfully!");
                        break;
                    }
                }
            }

            Utility.ContinueMessage();
        }

        // Method that view all songs in alphabetical order
        public static void ViewSongs()
        {
            Console.WriteLine("\n\t Songs in alphabetical order: ");

            foreach (var playlist in playlists)
            {
                foreach (var song in playlist.Songs)
                {
                    Console.WriteLine(song);
                }
            }

            Utility.ContinueMessage();
        }

        // Method that display shuffle songs at random
        public static void ShuffleSongs()
        {
            Console.WriteLine("\n\t Shuffle songs:");

            Random random = new Random();

            foreach (var playlist in playlists)
            {
                int index = random.Next(playlist.Songs.Count);
                Console.WriteLine(playlist.Songs[index]);
            }

            Utility.ContinueMessage();
        }
    }
}
