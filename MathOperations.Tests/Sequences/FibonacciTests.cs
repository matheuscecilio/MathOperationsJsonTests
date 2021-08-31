using FluentAssertions;
using MathOperations.Results.Sequences;
using MathOperations.Sequences;
using MathOperations.Tests.Common;
using Xunit;

namespace MathOperations.Tests.Sequences
{
    [Trait("UNIT", nameof(Methods.Fibonacci))]
    public class FibonacciTests
    {
        [Theory]
        [InlineData("/Sequences/Data/Fibonacci/fibonacci-001.json")]
        [InlineData("/Sequences/Data/Fibonacci/fibonacci-002.json")]
        [InlineData("/Sequences/Data/Fibonacci/fibonacci-003.json")]
        [InlineData("/Sequences/Data/Fibonacci/fibonacci-004.json")]
        [InlineData("/Sequences/Data/Fibonacci/fibonacci-005.json")]
        public void ShouldCalculateFibonacciCorrectly(string path)
        {
            var data = JsonConverter.GetValueFromPath<Data>(path);

            var result = Methods.Fibonacci(data.Input);

            result.Should().BeEquivalentTo(data.Output);
        }

        private struct Data
        {
            public int Input { get; set; }
            public FibonacciResult Output { get; set; }
        }
    }
}
