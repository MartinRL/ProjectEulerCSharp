using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerCSharp.Sequences
{
    /// <summary>
    /// Spec: http://www.wolframalpha.com/input/?i=Fibonacci&a=*C.Fibonacci-_*Function-
    /// </summary>
    public class FibonacciSequence : IEnumerable<int>
    {
        private readonly IEnumerable<int> sequence;

        public FibonacciSequence()
        {
            sequence = 1.ToMax().Select(CalculateFibonacci);
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