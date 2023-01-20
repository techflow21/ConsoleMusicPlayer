namespace ConsoleMusicPlayer
{
    internal class Menu
    {
        public void MenuOption()
        {
            while (true)
            {
                Console.Title = "Console Music Player";

                Console.Write("\n\t ========================================\n\t |==><=    Console Music Player    =><==|\n\t ========================================\n\t What will you like to do?\n\n\t 1. View all playlists with songs\n\t 2. Create new playlist\n\t 3. Add song to playlist\n\t 4. Delete playlist\n\t 5. Delete song from playlist\n\t 6. View all songs in alphabetical order\n\t 7. View all songs at random\n\t 8. Exit\n\n\t ");

                int choice;
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        AppMethods.ViewPlaylists();
                        break;
                    case 2:
                        AppMethods.CreatePlaylist();
                        break;
                    case 3:
                        AppMethods.AddSong();
                        break;
                    case 4:
                        AppMethods.DeletePlaylist();
                        break;
                    case 5:
                        AppMethods.DeleteSong();
                        break;
                    case 6:
                        AppMethods.ViewAllSongsAlphabetical();
                        break;
                    case 7:
                        AppMethods.ViewAllSongsRandom();
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("\n\t Invalid choice. Please try again.\n\t ");
                        break;
                }
            }

        }
    }
}
