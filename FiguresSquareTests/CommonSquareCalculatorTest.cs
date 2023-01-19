using FiguresSquare;


namespace FiguresSquareTests
{
    public class CommonSquareCalculatorTest
    {
        [Theory]
        [InlineData(15, 12, 12, 70)]
        [InlineData(25, 12, 15, 63)]
        [InlineData(16, 15, 25, 114)]
        public void Is_Triangle_Square_Valid(double a, double b, double c, double expectedSquare)
        {
            var commonSquareCalculator = new CommonSquareCalculator();
            var result = commonSquareCalculator.ComputeSquare(a, b, c);
            Assert.Equal(expectedSquare, result, 0);
        }

        [Theory]
        [InlineData(10, 314)]
        [InlineData(5, 79)]
        public void Is_Circle_Square_Valid(double radius, double expectedSquare)
        {
            var commonSquareCalculator = new CommonSquareCalculator();
            var result = commonSquareCalculator.ComputeSquare(radius);
            Assert.Equal(expectedSquare, result, 0);
        }

        [Theory]
        [InlineData(10, 10, 10, 10)]
        [InlineData(20, 20, 20, 20)]
        public void Is_Exception_Thrown(double a, double b, double c, double d)
        {
            var commonSquareCalculator = new CommonSquareCalculator();
            Assert.Throws<ArgumentException>(() => commonSquareCalculator.ComputeSquare(a, b, c, d));
        }
    }
}
