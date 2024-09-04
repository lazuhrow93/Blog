namespace FakeItTillYouMakeIt.DataModel
{
    public class Song
    {
        public string? Album { get; set; }
        public Artist? Artist { get; set; }
        public List<Artist>? Features { get; set; }
        public string? Name { get; set; }
        public long? NumberOfPlays { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
