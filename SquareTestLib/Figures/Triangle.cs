namespace SquareTestLib.Figures
{
    public class Triangle : ISquarable
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        private readonly TriangleType _type;

        private readonly List<double> _sorted;

        public enum TriangleType
        {
            RightAngleTriangle,
            CommonTriangle
        }

        public Triangle(double a, double b, double c)
        {
            if (a + b < c || a + c < b || b + c < a || a <= 0 || b <= 0 || c <= 0)
            {
                throw new InvalidOperationException("There is no triangle with such sides");
            }

            _a = a;
            _b = b;
            _c = c;

            _sorted = new[] { a, b, c }.OrderBy(x => x).ToList();

            if (Math.Pow(_sorted[0], 2) + Math.Pow(_sorted[1], 2) == Math.Pow(_sorted[2], 2))
            {
                _type = TriangleType.RightAngleTriangle;
            }
            else
            {
                _type = TriangleType.CommonTriangle;
            }
        }

        public double GetSquare()
        {
            if (_type == TriangleType.RightAngleTriangle)
            {
                return _sorted[0] * _sorted[1] / 2;
            }

            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }
    }
}
