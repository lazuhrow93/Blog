using FakeItTillYouMakeIt.DataModel;
using FakeItTillYouMakeIt.Faker;
using Xunit.Abstractions;

namespace FakeItTillYouMakeIt
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper _output;

        public UnitTest1(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Test1()
        {
            SongFaker songFaker = new SongFaker();
            var songs = songFaker.Generate(2); //make 10 artists

            string Description(Song song)
                => $"{song.Name} by {song.Artist!.Name}";
            string Features(Song song)
                => $"Featured: \n" +
                   $"{string.Join("\n", song.Features.Select(a => a.Name))}";

            foreach(var song in songs)
            {
                _output.WriteLine(Description(song));
                _output.WriteLine(Features(song));
                _output.WriteLine("");
            }
        }
    }
}