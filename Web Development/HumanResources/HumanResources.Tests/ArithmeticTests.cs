using Xunit;

namespace HumanResources.Tests
{
    public class ArithmeticTests
    {
        [Fact]
        public void SumSquaresTests()
        {
            // Arrange
            Arithmetic arithmetic = new Arithmetic();
            
            // Act
            var result = arithmetic.SumSquares(1, 2);
            var result1 = arithmetic.SumSquares(1, 2, 3);

            // Assert
            Assert.Equal(5, result);
            Assert.Equal(14, result1);
        }
    }
}