using Bogus;
using FakeItTillYouMakeIt.DataModel;

namespace FakeItTillYouMakeIt.Faker
{
    public class SongFaker : Faker<Song>
    {
        public SongFaker()
        {
            RuleFor(s => s.Album, f => string.Join(" ", f.Lorem.Words(4))); //create a album name based off 4 random words
            RuleFor(s => s.Artist, () => new ArtistFaker().Generate());
            RuleFor(s => s.Features, () => new ArtistFaker().Generate(2));
            RuleFor(s => s.Name, f => f.Company.CatchPhrase());
            RuleFor(s => s.NumberOfPlays, f => f.Random.Int(1000, 2000000));
        }
    }
}
