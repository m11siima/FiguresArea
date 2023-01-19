using FiguresArea.Implementations;

namespace FiguresSquareTests
{
    public class TriangleTest
    {
        [Theory]
        [InlineData(15, 12, 12, 70)]
        [InlineData(25, 12, 15, 63)]
        [InlineData(16, 15, 25, 114)]
        public void Is_Triangle_Square_Valid(double a, double b, double c, double expectedSquare)
        {
            var triangle = new Triangle(a, b, c);
            var square = triangle.ComputeSquare();

            Assert.Equal(expectedSquare, square, 0);
        }

        [Theory]
        [InlineData(15, 12, 12, 56)]
        [InlineData(25, 12, 15, 34)]
        [InlineData(16, 15, 25, 333)]
        public void Is_Triangle_Square_InValid(double a, double b, double c, double expectedSquare)
        {
            var triangle = new Triangle(a, b, c);
            var square = triangle.ComputeSquare();

            Assert.NotEqual(expectedSquare, square, 0);
        }
    }
}
