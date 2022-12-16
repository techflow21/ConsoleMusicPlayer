using System.Xml.Linq;

namespace ConsoleMusicPlayer
{
    internal class Playlist
    {
        public string Name { get; set; }
        public List<string> Songs { get; set; }

        public Playlist(string name)
        {

            Name = name;
            Songs = new List<string>();
        }

        public void AddSong(string songName)
        {
            Songs.Add(songName);
        }
    }
}
