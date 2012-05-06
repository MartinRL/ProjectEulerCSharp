using System;
using FluentAssertions;
using System.Linq;
using ProjectEulerCSharp.Sequences;
using Xunit.Extensions;

namespace ProjectEulerCSharp
{
    public class Problem002
    {
        [Theory]
        [InlineData(89, 44)]
        [InlineData(4000000, 4613732)]
        public void should_find_4613732(int upperBound, int expectedSum)
        {
            var actualSum = new FibonacciSequence()
                .TakeWhile(term => term <= upperBound)
                .Where(term => term.IsEven())
                .Sum();

            actualSum.Should().Be(expectedSum);
        }
    }
}