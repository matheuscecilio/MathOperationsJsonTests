using MathOperations.Results.SecondDeegreEquations;
using System;

namespace MathOperations.SecondDeegreEquations
{
    public static partial class Methods
    {
        public static BhaskaraResult Bhaskara(
            double a,
            double b,
            double c
        )
        {
            var delta = CalcDelta(a, b, c);
            var squareRootOfDelta = Math.Sqrt(delta);

            return new()
            {
                X1 = CalcX1(a, b, squareRootOfDelta),
                X2 = CalcX2(a, b, squareRootOfDelta)
            };
        }

        private static double CalcDelta(
            double a,
            double b,
            double c
        )
            => Math.Pow(b, 2) - 4 * a * c;

        private static double CalcX1(
            double a,
            double b,
            double squareRootOfDelta
        )
            => (-b + squareRootOfDelta) / 2 * a;

        private static double CalcX2(
            double a,
            double b,
            double squareRootOfDelta
        )
            => (-b - squareRootOfDelta) / 2 * a;
    }
}
