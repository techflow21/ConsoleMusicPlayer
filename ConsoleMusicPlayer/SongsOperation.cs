
using static ConsoleMusicPlayer.Store;
using System.Text.RegularExpressions;

namespace ConsoleMusicPlayer
{
    internal static class SongsOperation
    {
        public static void AddMusic()
        {
            Console.WriteLine("Enter the name of song to add below: ");
            var musicName = Console.ReadLine();

            string musicPattern = @"[a-zA-Z0-9]{2,35}$";
            Regex regex = new(musicPattern);

            if (!regex.IsMatch(musicName))
            {
                Console.WriteLine("You entered an invalid music, try again!");
                AddMusic();
            }
        }


        public static void EditMusic()
        {
            ////
        }


        public static void DeleteMusic()
        {
            ////
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
            ////
        }

    }
}
