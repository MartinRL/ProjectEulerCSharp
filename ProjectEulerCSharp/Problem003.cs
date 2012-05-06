using FluentAssertions;
using Xunit;
using Xunit.Extensions;

namespace ProjectEulerCSharp
{
    public class Problem003
    {
        [Fact]
        public void dummy()
        {
            long i = 600851475143;
        }

        [Theory]
        [InlineData(13195, 29)]
        [InlineData(600851475143, 0)]
        public void should_find_largest_prime_factor( long term, int expectedLargestPrimeFactor )
        {
            var actualLargestPrimeFactor = 0;

            actualLargestPrimeFactor.Should().Be(expectedLargestPrimeFactor);
        }
    }
}