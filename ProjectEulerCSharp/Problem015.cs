using Xunit;

namespace ProjectEulerCSharp
{
    public class Problem015
    {
        [Fact]
        public void should_find_number_of_routes_through_a_20x20_grid()
        {
            40.Choose(20).Should().Be(0);
        }
    }
}
