using System.Linq;
using Xunit;

namespace ProjectEulerCSharp
{
    public class Problem014
    {
        [Fact]
        public void should_find_the_starting_number_less_than_1000000_that_produces_the_longest_chain()
        {

        }

        [Fact]
        public void should_find_10_as_count_for_13_as_seed()
        {
            var collatzSequence = new CollatzSequence(13);

            collatzSequence.Count().Should().Be(10);
        }
    }
}
