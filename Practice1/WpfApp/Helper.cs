using Lib;

namespace WpfApp
{
    public static class TitleExtensions
    {
        public static Song WithTrack(this Song song, int track)
        {
            if (song != null)
            {
                song.Track = track;
            }
            return song;
        }
    }
}