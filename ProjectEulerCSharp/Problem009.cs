using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace ProjectEulerCSharp
{
    public class Problem009
    {
        [Fact]
        public void should_find_pythagorean_triplet_for_which_sum_is_1000()
        {
            const int sum = 1000;

            1.To(sum / 2)
                .SelectMany(a => 1.To(sum / 2).SelectMany(b => 1.To(sum / 2).Select(c => new Triplet(a, b, c))))
                .First(t => t.Sum == sum && t.IsPythagorean)
                .Product
                .Should().Be(31875000);
        }

        private class Triplet
        {
            private readonly int a, b, c;

            internal Triplet(int a, int b, int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            internal int Sum
            {
                get { return a + b + c; }
            }

            internal bool IsPythagorean
            {
                get { return a.Sqr() + b.Sqr() == c.Sqr(); }
            }

            internal int Product
            {
                get { return a * b * c; }
            }
        }
    }
}
