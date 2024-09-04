namespace FakeItTillYouMakeIt.DataModel
{
    public class Playlist
    {
        public int UserName { get; set; }
        public string? PlaylistName { get; set; }
        public int SongCount { get; set; }
        public List<Song>? Songs { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
