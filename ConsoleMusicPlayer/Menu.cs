
namespace ConsoleMusicPlayer
{
    internal class Menu
    {
        private static string songName;
        private static string playlistName;

        public static void MenuOption()
        {
            Console.Clear();
            Utility.AppName();
            Console.Write("\tSelect your preferred menu option\n\n\t1. To view all Playlists\n\t2. To add new Playlist\n\t3. To delete a playlist\n\t4. To add new song to a playlist\n\t5. To view all songs in order of addition\n\t6. To view all songs in Alphabetical order\n\t7. To view Shuffle songs\n\t8. To Cancel\n\n\t");

            var menuOption = Console.ReadLine();

            switch (menuOption)
            {
                case "1":
                    {
                        Console.Clear();
                        Utility.AppName();
                        Operations.ViewPlaylists();
                        Utility.ContinueOption();
                    }
                    break;

                case "2":
                    {
                        Console.Clear();
                        Utility.AppName();
                        Operations.CreatePlaylist();
                        Utility.ContinueOption();
                    }
                    break;

                case "3":
                    {
                        Console.Clear();
                        Utility.AppName();
                        Operations.DeletePlaylist(playlistName);
                        Utility.ContinueOption();
                    }
                    break;

                case "4":
                    {
                        Console.Clear();
                        Utility.AppName();

                        /*Console.WriteLine("\n\t Enter the name of the playlist you would like to add a song to: \n\t ");
                        string playlistName = Console.ReadLine();

                        Console.Write("\n\t Enter the name of the song you would like to add: \n\t ");
                        string songName = Console.ReadLine();*/

                        Operations.AddSong(songName);
                        Utility.ContinueOption();
                    }
                    break;

                case "5":
                    {
                        Console.Clear();
                        Utility.AppName();
                        Operations.ShuffleSongs();
                        Utility.ContinueOption();
                    }
                    break;

                case "6":
                    {
                        Console.Clear();
                        Utility.AppName();
                        Operations.ShuffleSongs();
                        Utility.ContinueOption();
                    }
                    break;

                case "7":
                    {
                        Console.Clear();
                        Utility.AppName();
                        Operations.ShuffleSongs();
                        Utility.ContinueOption();
                    }
                    break;

                case "8":
                    {
                        Console.WriteLine("Thanks for using Console Music Player"); 
                    }
                    break;

                default:
                    {
                        Console.Clear();
                        Utility.AppName();
                        Utility.InvalidMessage();
                    }
                    break;
            }
        }
    }
}
