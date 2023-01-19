using FiguresArea.Implementations;
using FiguresSquare.Implementations;
using FiguresSquare.Interfaces;


namespace FiguresSquare
{
    public class CommonSquareCalculator : ICommonSquareCalculator
    {
        private Dictionary<int, Func<double[],IFigure>> _figures;

        public CommonSquareCalculator()
        {
            _figures = new Dictionary<int, Func<double[], IFigure>>();
            InitFiguresCreators();
        }
        public double ComputeSquare(params double[] edges)
        {
            if (!_figures.TryGetValue(edges.Length, out var creationFunc))
                throw new ArgumentException("Wrong arguments count provided");
            var figure = creationFunc(edges);
            return figure.ComputeSquare();
        }

        private void InitFiguresCreators()
        {
            _figures.Add(1, (double[] edges) => new Circle(edges[0]));
            _figures.Add(3, (double[] edges) => new Triangle(edges[0], edges[1], edges[2]));
        }
    }
}
