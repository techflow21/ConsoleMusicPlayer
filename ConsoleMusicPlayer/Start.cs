using System.Globalization;
using System.Text;

namespace ConsoleMusicPlayer
{
    internal class Start
    {
        internal static void AppStarter()
        {
            bool closeArea = false;

            Console.WriteLine("\nMAIN MENU\nWhat would you like to do?\nType 0 to close the Music Player\nType 1 to create new playlist\nType 2 to view all created playlists\n");
            while (closeArea == false)
            {
                string commandInput = Console.ReadLine();

                int option = Convert.ToInt32(commandInput);

                try
                {
                    switch (option)
                    {
                        case 0:
                            closeArea = true;
                            break;
                        case 1:
                            Crud.CreatePlayList();
                            break;
                        case 2:
                            Crud.ViewPlayLists();
                            break;
                        default:
                            Console.WriteLine("\nInvalid option, Please try again: \n");
                            AppStarter();
                            break;
                    }
                }
                catch
                {
                    /*if (string.IsNullOrEmpty(commandInput) || int.Parse(commandInput) != option)
                    {
                        Console.WriteLine("\nInvalid option. Please try again: ");
                        AppStarter();
                    }*/
                    Console.WriteLine("Invalid option selected, try again: ");
                    closeArea = false;
                } 
            }


        }

    }

}
