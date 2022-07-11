namespace FigureAreaCalculator.UnitTests
{
    public class AreaCalculatorUnitTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-7)]
        public void CalculateCircleArea_ShouldThrowsException_WhenRadiusNegativeOrZero(double radius)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => AreaCalculator.CalculateCircleArea(radius));
        }

        [Theory]
        [InlineData(5)]
        public void CalculateCircleArea_ShouldReturnArea_WhenRadiusValid(double radius)
        {
            Assert.Equal(expected: 78, (int)AreaCalculator.CalculateCircleArea(radius));
        }

        [Theory]
        [InlineData(0, 1, 2)]
        [InlineData(0, 0, 0)]
        [InlineData(1, 2, -3)]
        [InlineData(-5, -5, -5)]
        public void CalculateTriangleArea_ShouldThrowsException_WhenArgsNegativeOrZero(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => AreaCalculator.CalculateTriangleArea(sideA, sideB, sideC));
        }

        [Theory]
        [InlineData(5, 4, 3)]
        public void CalculateTriangleArea_ShouldReturnArea_WhenArgsValid(double sideA, double sideB, double sideC)
        {
            Assert.Equal(expected: 6, AreaCalculator.CalculateTriangleArea(sideA, sideB, sideC));
        }
    }
}
