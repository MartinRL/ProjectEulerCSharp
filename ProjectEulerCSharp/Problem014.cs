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
            1.To(1000000 - 1)
                .Select(t => new {Term = t, Count = new CollatzSequence(t).Count})
                .OrderByDescending(tc => tc.Count)
                .First().Term
                .Should().Be(0);
        }

        [Fact]
        public void should_find_10_as_count_for_13_as_seed()
        {
            var collatzSequence = new CollatzSequence(13);

            collatzSequence.Count.Should().Be(10);
        }
    }

    public class CollatzSequence : IEnumerable<int>
    {
        private readonly int seed;

        public CollatzSequence(int seed)
        {
            this.seed = seed;
        }

        public ulong Count
        {
            get
            {
                ulong count = 0;
                var enumerator = GetEnumerator();
                while (enumerator.MoveNext())
                {
                    count++;
                }

                return count;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new Enumerator(seed);
        }

        public class Enumerator : IEnumerator<int>
        {
            private int current;
            private bool hasMoved;

            public Enumerator(int current)
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
