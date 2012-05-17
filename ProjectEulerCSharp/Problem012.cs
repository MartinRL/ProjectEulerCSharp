using System.Linq;
using FluentAssertions;
using Xunit.Extensions;

namespace ProjectEulerCSharp
{
    public class Problem012 : Problem
    {
        [Theory]
        [InlineData(5, 28)]
        [InlineData(500, 76576500)]
        public void should_find_first_triangle_number_for_number_of_divisors(int numberOfDivisors, int expectedTriangleNumber)
        {
            1.ToMax().Select(TriangleNumber)
                .First(t => t.NumberOfDivisors() > numberOfDivisors)
                .Should().Be(expectedTriangleNumber);
        }
    }
}