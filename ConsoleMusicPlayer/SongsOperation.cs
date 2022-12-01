/*
using static ConsoleMusicPlayer.Store;
using System.Text.RegularExpressions;

namespace ConsoleMusicPlayer
{
    internal static class SongsOperation
    {
        public static PlayLists AddMusic()
        {
            Console.WriteLine("Enter the name of music to add below (Supported Formats are .mp3, .acc and .wav)");
            var musicName = Console.ReadLine();

            string musicPattern = @"[a-zA-Z0-9]{2,35}.(mp3|acc|wav)$";
            Regex regex = new(musicPattern);

            if (!regex.IsMatch(musicName))
            {
                Console.WriteLine("You entered an invalid music, try again!");
                AddMusic();
            }
            else
            {
                int musicListId = 0;

                foreach (var musicList in GetMusicList())
                {
                    if (musicList.Id != musicListId)
                    {
                        playListId += 1;
                    }
                }

                GetMusicList().Add(new MusicLists { Id = musicListId += 1, MusicListName = musicListName });
                Console.WriteLine("\nMusic added successfully!\n\n>>>>>>>> Available Musics <<<<<<<<<<<<\n");

                GetMusicList().ForEach(musicList => Console.WriteLine($"{musicList.Id}:    {musicList.musicListName}\n"));

                //SelectMusicList();
            }
        }


        public static void EditMusic()
        {
            //
        }


        public static void DeleteMusic()
        {
            //
        }
        public static void PreviousOperation()
        {
            //
        }
        public static void NextOperation()
        {
            //
        }

        public static void ShuffleMusic()
        {
            //
        }

        public static void PlayInOrder()
        {
            //
        }

        public static void PlayAlphabetically()
        {
            //
        }
    }
}
*/