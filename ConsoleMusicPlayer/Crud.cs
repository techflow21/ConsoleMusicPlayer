using System.Text.RegularExpressions;
using static ConsoleMusicPlayer.Store;

namespace ConsoleMusicPlayer
{
    internal class Crud
    {
        private static object playListSongs;

        static List<PlayLists> GetPlayList()
        {
            return playLists;
        }
        static List<MusicLists> GetMusicList()
        {
            return musicLists;
        }

        /*static List<PlayListSongs> GetPlayListSong()
        {
            return playListSongs;
        }*/


        private static List<string> MyPlaylist = new List<string>();


        public static void CreatePlayList()
        {
            Console.WriteLine("Enter playList name to add below: ");
            var playListName = Console.ReadLine();

            string playListPattern = @"[a-zA-Z0-9]{2,20}$";
            Regex regex = new(playListPattern);

            if (!regex.IsMatch(playListName))
            {
                Console.WriteLine("You entered an invalid paylist name, try again!");
                CreatePlayList();
            }
            else
            {
                PlaylistStore.Add(playListName, AddMusicTrack());
                /*int playListId = 0;

                foreach (var playList in GetPlayList())
                {
                    if (playList.Id != playListId)
                    {
                        playListId += 1;
                    }
                }*/

                //GetPlayList().Add(new PlayLists { Id = playListId += 1, playListName = playListName });
                //Console.WriteLine("\nPlaylist added successfully!\n\n>>>>>>>> Available Playlists <<<<<<<<<<<<\n");

                //GetPlayList().ForEach(playList => Console.WriteLine($"{playList.Id}:    {playList.playListName}\n"));

                //SelectPlayList();
            }
        }

        public static void ViewPlayLists()
        {
            Console.WriteLine(">>>>>>>> Available Playlists <<<<<<<<<<<<\n");
            GetPlayList().ForEach(playList => Console.WriteLine($"{playList.Id}:   {playList.playListName}\n"));

            SelectPlayList();
        }

        public static void SelectPlayList()
        {
            Console.WriteLine("Enter 1 to add another playlist\nEnter 2 to Select your favorite playlist");

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
                        PlayListSongs();
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

        public static void PlayListSongs()
        {
            Console.WriteLine("Enter 1 to see all available songs\nEnter 2 to access the playlist ID of the available songs: \n");
            var inputOption = Console.ReadLine();

            switch (inputOption)
            {
                case "1":
                    {
                        ViewAllSongs();
                    }
                    break;

                case "2":
                    {
                        PlaylistSongsOption();
                    }
                    break;

                default:
                    {
                        Console.WriteLine("You've entered an invalid  option, try again!");
                        PlayListSongs();
                    }
                    break;
            }
        }

        public static void PlaylistSongsOption()
        {
            GetPlayList().ForEach(playList => Console.WriteLine($"{playList.Id}:   {playList.playListName}\n"));

            Console.WriteLine("Enter any of the Song's ID to select: \n");

            var option = Console.ReadLine();

            GetPlayList().ForEach(playList =>
            {
                try
                {
                    if (playList.Id == int.Parse(option))
                    {
                        Console.WriteLine($"{playList.playListName.ToUpper()} selected!\n");

                        ViewPlaylistSongs();
                    }
                }
                catch
                {
                    Console.WriteLine("You entered invalid playlist ID, try again");
                    PlaylistSongsOption();
                }
            });
        }

        public static void ViewAllSongs()
        {
            Console.WriteLine(">>>>>>>> Available Songs <<<<<<<<<<<<\n");
            GetMusicList().ForEach(song => Console.WriteLine($"{song.Id}:     {song.trackName} with Playlist ID of {song.playListId}\n"));
            //SongsOperation();
        }

        public static void ViewPlaylistSongs()
        {
            foreach (PlayLists playList in playLists)
            {
                foreach (MusicLists musicList in musicLists)
                {
                    if (playList.Id == musicList.playListId)
                    {
                        List <PlayListSongs> playListSongs = new List <PlayListSongs>()
                        {
                            new PlayListSongs{Id = playList.Id, song = musicList.trackName }
                        };
                        
                        playListSongs.ForEach(songItem => Console.WriteLine($"{songItem.Id}:      {songItem.song}\n"));
                    }
                }
            }

        }

        private static List<string> AddMusicTrack()
        {
            bool IsActive = true;
            string pattern = @"[a-zA-Z0-9]{2,45}";
            Regex regex = new Regex(pattern);

            Console.WriteLine("Enter music track name you wish to add to playlist\n");
            
            var musicTracks = new List<string>();


            while (IsActive)
            {
                Console.WriteLine("Enter Music track name below: \n");
                string? musicTrack = Console.ReadLine();
                if (regex.IsMatch(musicTrack))
                {
                    musicTracks.Add(musicTrack);
                }
                else
                {
                    Console.WriteLine("You entered an invalid music track name, try again!");
                }

                Console.Write("Enter 2 to stop adding music track or Enter any other key to continue adding: ");
                string option = Console.ReadLine();
                if (option == "2")
                {
                    IsActive = false;
                }
            }
            return musicTracks;
        }
    }
}
