namespace HumanResources.Tests
{
    public class Arithmetic
    {
        // Calculate sum of squares of all parameters
        public double SumSquares(params double[] numbers) => numbers.Select(x => x * x).Sum();
    }
}