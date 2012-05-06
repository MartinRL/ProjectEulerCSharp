using System;
using System.Collections;
using System.Collections.Generic;
using FluentAssertions;
using System.Linq;
using Xunit;
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

    public class FibonacciSequence : IEnumerable<int>
    {
        private readonly IEnumerable<int> sequence;

        public FibonacciSequence()
        {
            sequence = 1.To(int.MaxValue).Select(CalculateFibonacci);
        }

        private int CalculateFibonacci(int index)
        {
            if (index <= 1)
                return 1;

            return CalculateFibonacci(index - 1) + CalculateFibonacci(index - 2);
        }

        public IEnumerator<int> GetEnumerator()
        {
            return sequence.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}