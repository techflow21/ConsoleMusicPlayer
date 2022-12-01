using System.Text.RegularExpressions;
using static ConsoleMusicPlayer.Store;

namespace ConsoleMusicPlayer
{
    internal class Crud
    {
        static List<PlayLists> GetPlayList()
        {
            return playLists;
        }
        static List<MusicLists> GetMusicList()
        {
            return musicLists;
        }

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
                int playListId = 0;

                foreach (var playList in GetPlayList())
                {
                    if (playList.Id != playListId)
                    {
                        playListId += 1;
                    }
                }

                GetPlayList().Add(new PlayLists { Id = playListId += 1, playListName = playListName });
                Console.WriteLine("\nPlaylist added successfully!\n\n>>>>>>>> Available Playlists <<<<<<<<<<<<\n");

                GetPlayList().ForEach(playList => Console.WriteLine($"{playList.Id}:    {playList.playListName}\n"));

                SelectPlayList();
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
           GetMusicList().ForEach(song =>
           {
               if (song.playListId.Equals(GetPlayList().ForEach(playList => playList.Id)
               {

               }

              
           });
            //Console.WriteLine($"{song.Id}:     {song.trackName} with Playlist ID of {song.playListId}\n"));
           
        }

        public static PlayLists AddMusic()
        {
            Console.WriteLine("Enter the name of music to add below (Supported Formats are .mp3, .acc and .wav)");
            var musicName = Console.ReadLine();

            string musicPattern = @"[a-zA-Z0-9]{2,35}.(mp3|acc|wav)$";
            Regex regex = new(musicPattern);

            if (!regex.IsMatch(musicName))
            {
                Console.WriteLine("You entered an invalid music, try again!");
                CreatePlayList();
            }
            else
            {
                //PlayLists playLists = new PlayLists();
                GetPlayList().Add(AddMusic());
                Console.WriteLine("Music added successfully!");
            }
            return AddMusic();
        }


        public static void EditMusic()
        {
            //
        }


        public static void DeleteMusic()
        {
            //
        }

    }
}
