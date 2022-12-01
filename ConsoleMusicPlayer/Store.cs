
using static ConsoleMusicPlayer.Store;

namespace ConsoleMusicPlayer
{
    internal static class Store
    {
        public class PlayLists
        {
            public int Id { get; set; }
            public string playListName { get; set; }
        }

        public static List<PlayLists> playLists = new List<PlayLists>
        {
            new PlayLists { Id = 1, playListName = "Naija Hiphop" },
            new PlayLists { Id = 2, playListName = "American Blues" },
            new PlayLists { Id = 3, playListName = "Hit Songs" }
        };
        
        public class MusicLists
        {
            public int Id { get; set; }
            public string trackName { get; set; }
            public string singer { get; set; }
            public int playListId { get; set; }
        }

        public static List<MusicLists> musicLists = new List<MusicLists>
        {
            new MusicLists { Id = 1, trackName ="Mo Lenu" , singer = "Olamide", playListId = 2},
            new MusicLists { Id = 2, trackName ="OBO", singer = "Davido", playListId = 2},
            new MusicLists { Id = 3, trackName ="Young Forever", singer = "Jay Z", playListId = 3}
        };

        public class PlayListSongs
        {
            public int Id { get; set; }
            public string song { get; set; }
        }

        public static List<PlayListSongs> playListSongs = new List<PlayListSongs> {};

    }
}
