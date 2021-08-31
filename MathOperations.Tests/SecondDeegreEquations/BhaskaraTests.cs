using FluentAssertions;
using MathOperations.Results.SecondDeegreEquations;
using MathOperations.SecondDeegreEquations;
using MathOperations.Tests.Common;
using Xunit;

namespace MathOperations.Tests.SecondDeegreEquations
{
    [Trait("UNIT", nameof(Methods.Bhaskara))]
    public class BhaskaraTests
    {
        [Theory]
        [InlineData("SecondDeegreEquations/Datas/Bhaskara/bhaskara-001.json")]
        [InlineData("SecondDeegreEquations/Datas/Bhaskara/bhaskara-002.json")]
        [InlineData("SecondDeegreEquations/Datas/Bhaskara/bhaskara-003.json")]
        public void ShouldCalculateBhaskaraCorrectly(string path)
        {
            var data = JsonConverter.GetValueFromPath<Data>(path);
            
            var result = Methods.Bhaskara(
                data.Input.A,
                data.Input.B,
                data.Input.C
            );

            result.Should().BeEquivalentTo(data.Output);
        }

        private struct Data
        {
            public Input Input { get; set; }
            public BhaskaraResult Output { get; set; }
        }

        private struct Input
        {
            public double A { get; set; }
            public double B { get; set; }
            public double C { get; set; }
        }
    }
}
