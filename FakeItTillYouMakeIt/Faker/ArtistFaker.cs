using Bogus;
using FakeItTillYouMakeIt.DataModel;

namespace FakeItTillYouMakeIt.Faker
{
    public class ArtistFaker : Faker<Artist>
    {
        public ArtistFaker()
        {
            RuleFor(a => a.Name, f => f.Person.FullName);
        }
    }
}
