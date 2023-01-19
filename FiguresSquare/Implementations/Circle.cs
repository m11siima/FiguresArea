using FiguresSquare.Interfaces;

namespace FiguresSquare.Implementations
{
    public class Circle : ICircle
    {
        public double Radius { get; }

        public Circle(double radius) => Radius = radius;

        public double ComputeSquare() => Math.PI * Math.Pow(Radius, 2);
    }
}
