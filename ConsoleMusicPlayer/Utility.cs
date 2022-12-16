
namespace ConsoleMusicPlayer
{
    internal class Utility
    {
        public static void AppName()
        {
            Console.WriteLine("\n**********  Console Music Player  ******************\n\n");
        }

        public static void InvalidMessage()
        {
            Console.WriteLine("\n\tYou entered an invalid option! enter Y/N: ");
        }

        public static void InvalidAmount()
        {
            Console.WriteLine("\n\tYou entered an invalid amount!, try again? enter Y/N: ");
        }

        public static void Delay()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.Write("\n\n\tProcessing...");
                Thread.Sleep(1000);
            }
        }

        public static void ContinueOption()
        {
            string option = Console.ReadLine();

            switch (option.ToUpper())
            {
                case "Y":
                    Menu.MenuOption();
                    break;

                case "N":
                    Console.WriteLine("\n\t Thank you for using Console Music Player");
                    break;

                default:
                    InvalidMessage();
                    ContinueOption();
                    break;
            }

        }

        public static void ContinueMessage()
        {
            Console.Write("\n\t Will you like to continue (Y/N):\n\t ");
        }
    }
}
