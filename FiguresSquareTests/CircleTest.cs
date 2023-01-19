using FiguresSquare.Implementations;

namespace FiguresSquareTests
{
    public class CircleTest
    {
        [Theory]
        [InlineData(10, 314)]
        [InlineData(5, 79)]
        public void Is_Circle_Square_Valid(double radius, double expectedSquare)
        {
            var circle = new Circle(radius);
            var square = circle.ComputeSquare();
            Assert.Equal(expectedSquare, square, 0);
        }

        [Theory]
        [InlineData(10, 334)]
        [InlineData(5, 80)]
        public void Is_Circle_Square_Invalid(double radius, double expectedSquare)
        {
            var circle = new Circle(radius);
            var square = circle.ComputeSquare();
            Assert.NotEqual(expectedSquare, square);
        }
    }
}