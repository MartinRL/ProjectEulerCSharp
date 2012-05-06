using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerCSharp.Sequences
{
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