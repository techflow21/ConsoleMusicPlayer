using System.Text.RegularExpressions;
using static ConsoleMusicPlayer.Store;

namespace ConsoleMusicPlayer
{
    internal class Crud
    {
        private static object playListSongs;

        public static List<string> MyPlaylist = new List<string>();

        public static void CreatePlayList()
        {
            Console.WriteLine("Enter playList name to add below: ");
            var playListName = Console.ReadLine();

            string playListPattern = @"[a-zA-Z0-9]{2,20}$";
            Regex regex = new(playListPattern);

            if (regex.IsMatch(playListName))
            {
                PlaylistStore.Add(playListName, AddMusicTrack());
            }
            else
            {
                Console.WriteLine("You entered an invalid paylist name, try again!");
                CreatePlayList();
            }
        }

        public static void ViewPlayLists()
        {
            int indexCount = 0;
            Console.WriteLine(">>>>>>>> Available Playlists <<<<<<<<<<<<\n");

            foreach (KeyValuePair<string, List<string>> playlist in Playlists)
            {
                playlist.Value.ForEach(playlistId => Console.WriteLine($"{indexCount}:     {playlist.Key}\n"));
                indexCount++;
            }

            SelectPlayList();
        }

        public static void SelectPlayList()
        {
            Console.WriteLine("\n   Enter 1 to add another playlist\n\n   Enter 2 to Select your favorite playlist\n");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    {
                        CreatePlayList();
                    }
                    break;

                case "2":
                    {
                        //PlayListSongs();
                    }
                    break;

                default:
                    {
                        Console.WriteLine("You've selected an invalid playlist option, try again!");
                        SelectPlayList();
                    }
                    break;
            }
        }


        public static void PlaylistAddSong()
        {
            int indexCount = 0;
            Console.WriteLine("Enter the Playlist Number to add Song to the playlist\n");

            foreach (KeyValuePair<string, List<string>> playList in Playlists)
            {
                indexCount++;
                Console.Write($"{indexCount}:   {playList.Key}\n");
                MyPlaylist.Add(playList.Key);
            }

            Console.WriteLine("\nEnter 0 to Goto to Music Player Main Menu\nEnter 1 to Add Song\n");
            string InputOption = Console.ReadLine();

            string pattern = @"[0-2]{1}$";
            Regex regex = new(pattern);

            if (regex.IsMatch(InputOption))
            {
                switch (InputOption)
                {
                    case "0":
                        Console.Clear();
                        Start.AppStarter();
                        break;
                    case "1":
                        Console.Clear();
                        SongHandler(playlistIndex);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid entry, Try again! ");
                        PlaylistAddSong();
                        break;
                }
            }
        }


        private static List<string> AddMusicTrack()
        {
            bool IsActive = true;
            string pattern = @"[a-zA-Z0-9]{2,45}$";
            Regex regex = new Regex(pattern);

            var musicTracks = new List<string>();


            while (IsActive)
            {
                Console.WriteLine("Enter music track name you wish to add to playlist\n");
                string? musicTrack = Console.ReadLine();
                if (regex.IsMatch(musicTrack))
                {
                    musicTracks.Add(musicTrack);
                }
                else
                {
                    Console.WriteLine("You entered an invalid music track name, try again!\n");
                }
                Console.Write("\nEnter 2 to stop adding music track or Enter any other key to continue adding: \n");
                string option = Console.ReadLine();
                if (option == "2")
                {
                    IsActive = false;
                }
            }
            return musicTracks;
        }

        public static void SongHandler(int playlistIndex)
        {
            DisplaySongs(playlistIndex);
            int SongIndex = playlistIndex - 1;

            Console.WriteLine($"Enter Song to Add to the playlist or\nEnter 0 to return to Music player Main Menu\n");
            string InputOption = Console.ReadLine();
            switch (InputOption)
            {
                case "0":
                    Console.Clear();
                    Start.AppStarter();
                    break;
                default:
                    Playlists[MyPlaylist[SongIndex]].Add(InputOption);
                    int Count = 0;
                    SongHandler(playlistIndex);
                    break;
            }

        }

        public static void DisplaySongs(int index)
        { 
            int count = 0;
            string Playlist = MyPlaylist[index - 1];
            Console.Clear();
            
            foreach (string song in Playlists[Playlist])
            {
                count++;
                Console.Write($"{count}: ");
                Console.WriteLine(song);
            }

            Console.WriteLine($"Showing Playlist {Playlist}\n");
        }
    }
 
}
