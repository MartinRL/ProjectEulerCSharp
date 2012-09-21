using FluentAssertions;
using Xunit;

namespace ProjectEulerCSharp
{
    public class Problem015
    {
        [Fact]
        public void should_find_number_of_routes_through_a_20x20_grid()
        {
            // Google: http://www.google.com/search?q=40+choose+20
            40.Choose(20).Should().Be(137846528820);
        }
    }
}
