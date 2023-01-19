using FiguresSquare.Interfaces;

namespace FiguresArea.Implementations
{
    public class Triangle : ITriangle
    {
        private Lazy<bool> _isRightAngle;

        public double EdgeA { get; }

        public double EdgeB { get; }

        public double EdgeC { get; }
        public Triangle(double edgeA, double edgeB, double edgeC) 
        {
            CheckEdges(edgeA, edgeB, edgeC);

            EdgeA = edgeA;
            EdgeB = edgeB;
            EdgeC = edgeC;

            _isRightAngle = new Lazy<bool>(CheckTriangleRight);
        }

        public bool IsRightAngle => _isRightAngle.Value;

        public double ComputeSquare()
        {
            var halfPerimetr = (EdgeA + EdgeB + EdgeC) / 2d;
            return Math.Sqrt(
                halfPerimetr
                * (halfPerimetr - EdgeA)
                * (halfPerimetr - EdgeB)
                * (halfPerimetr - EdgeC)
            );
        }

        private bool CheckTriangleRight()
        {
            if((EdgeA * EdgeB) == EdgeC || (EdgeB * EdgeC) == EdgeA || (EdgeA * EdgeC) == EdgeB)
                return true;
            return false;
        }

        private void CheckEdges(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("One or more edges are invalid");
            var maxEdge = Math.Max(a, Math.Max(b, c));
            var perimeter = a + b + c;
            if (perimeter <= maxEdge * 2)
                throw new ArgumentException("Max edge should be less than perimeter");
        }
    }
}
