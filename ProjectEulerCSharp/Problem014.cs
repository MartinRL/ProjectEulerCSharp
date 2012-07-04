using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
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

            foreach (var t in collatzSequence)
            {
                Console.WriteLine(t);
            }

            collatzSequence.Count().Should().Be(10);
        }
    }

    public class CollatzSequence : IEnumerable<int>
    {
        private readonly int seed;

        public CollatzSequence(int seed)
        {
            this.seed = seed;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new CollatzSequenceEnumerator(seed);
        }

        public class CollatzSequenceEnumerator : IEnumerator<int>
        {
            private int current;
            private bool hasMoved;

            public CollatzSequenceEnumerator(int current)
            {
                hasMoved = false;
                this.current = current;
            }

            public void Dispose()
            {}

            public bool MoveNext()
            {
                if (Current == 1)
                    return false;

                if (hasMoved)
                    current = current.IsEven() ? current / 2 : 3 * current + 1;

                hasMoved = true;

                return true;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public int Current
            {
                get { return current; }
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
