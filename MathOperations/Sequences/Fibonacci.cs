using MathOperations.Results.Sequences;
using System.Collections.Generic;
using System.Linq;

namespace MathOperations.Sequences
{
    public static partial class Methods
    {
        public static FibonacciResult Fibonacci(int sequenceLength)
        {
            var result = new FibonacciResult();

            for (int index = 0; index < sequenceLength; index++)
            {
                if (index == 0)
                {
                    result.Values.Add(1);
                    continue;
                }

                var v1 = result.Values.ElementAtOrDefault(index - 1) ?? 0;
                var v2 = result.Values.ElementAtOrDefault(index - 2) ?? 0;

                result.Values.Add(v1 + v2);
            }

            return result;
        }
    }
}
