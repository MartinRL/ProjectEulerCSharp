using System.Linq;
using FluentAssertions;
using Xunit.Extensions;

namespace ProjectEulerCSharp
{
    public class Problem006
    {
        [Theory]
        [InlineData(10, 2640)]
        [InlineData(100, 25164150)]
        public void should_find_the_difference_between_the_sum_of_the_squares_and_the_square_of_the_sum(int upperBound, int expected)
        {
            var naturalNumbers = 1.To(upperBound);

            var squareOfTheSums = naturalNumbers.Sum().Sqr();

            var sumOfTheSquares = naturalNumbers.Select(t => t.Sqr()).Sum();

            var actual = squareOfTheSums - sumOfTheSquares;

            actual.Should().Be(expected);
        }
    }
}