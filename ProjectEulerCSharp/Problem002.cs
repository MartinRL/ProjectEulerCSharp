using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using ProjectEulerCSharp.Sequences;
using Xunit.Extensions;

namespace ProjectEulerCSharp
{
    public class Problem002
    {
        [Theory]
        [InlineData(89, 44)]
        [InlineData(4000000, 4613732)]
        public void should_find_sum_of_even_valued_terms(int upperBound, int expectedSum)
        {
            new FibonacciSequence()
                .TakeWhileLessThan(upperBound)
                .Where(term => term.IsEven())
                .Sum().Should().Be(expectedSum);
        }
    }
}
