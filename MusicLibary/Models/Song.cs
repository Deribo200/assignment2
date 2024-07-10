namespace MusicLibary.Models
{
    public class Song
    {
        public int SongId { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
        public string Artist { get; set; }
    }
}
