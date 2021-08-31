using System.Collections.Generic;

namespace MathOperations.Results.Sequences
{
    public class FibonacciResult
    {
        public FibonacciResult()
        {
            Values = new();
        }

        public List<int?> Values { get; set; }
    }
}
