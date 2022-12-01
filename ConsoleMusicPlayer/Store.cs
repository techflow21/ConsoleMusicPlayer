
namespace ConsoleMusicPlayer
{
    internal static class Store
    {
        public static List<string> ChrisBrownList = new List<string>() { "With you", "Hit the road", "Say Hi", "What's Cool" };
        public static List<string> AmericanBlues = new List<string>() { "Sunny day", "Say you wanna read my mind", "False Alarm", "Say Goodbye" };

        public static Dictionary<string, List<string>> Playlists = new Dictionary<string, List<string>>()
        {
            {"Chris Brown List", ChrisBrownList },
            {"American Blues", AmericanBlues }
        };

        public static SortedDictionary<string, List<string>> PlaylistStore = new SortedDictionary<string, List<string>>(Playlists);

    }
}


