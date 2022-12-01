using System.Globalization;
using System.Text;

namespace ConsoleMusicPlayer
{
    internal class Start
    {
        internal static void AppStarter()
        {
            bool closeArea = false;

            Console.WriteLine("\n|======= Console Music Player MAIN MENU ========|\n|        What would you like to do?\n|        Type 1 to create new playlist\n|        Type 2 to view all Created Playlists\n|        Type 3 Add Songs to Playlist\n|        Type 4 to Edit Songs\n|        Type 5 to Delete Songs\n|        Type 6 to view songs in Alphabetical Order\n|        Type 7 to view songs in Added Order\n|        Type 8 to view Shuffle list of Songs");
            
            while (closeArea == false)
            {
                string commandInput = Console.ReadLine();

                try
                {
                    switch (commandInput)
                    {
                        case "1":
                            Console.Clear();
                            Crud.CreatePlayList();
                            break;
                        case "2":
                            Console.Clear();
                            Crud.ViewPlayLists();
                            break;
                        case "3":
                            Console.Clear();
                            Crud.PlaylistAddSong();
                            break;
                        case "4":
                            Console.Clear();
                            //Crud.ViewPlayLists();
                            break;
                        case "5":
                            Console.Clear();
                            //Crud.ViewPlayLists();
                            break;
                        case "6":
                            Console.Clear();
                            //Crud.ViewPlayLists();
                            break;
                        case "7":
                            Console.Clear();
                            //Crud.ViewPlayLists();
                            break;
                        case "8":
                            Console.Clear();
                            //Crud.ViewPlayLists();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("\nInvalid option entered, try again: \n");
                            AppStarter();
                            break;
                    }
                }
                catch
                {
                    closeArea = false;
                    Console.WriteLine("Invalid option entered, try again: \n");
                    AppStarter();
                }
            }

        }

    }

}
