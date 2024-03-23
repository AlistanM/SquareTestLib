using SquareTestLib.Figures;

namespace SquareTestLib
{
    public class SquarableFactory
    {
        public ISquarable CreateCircle(double r)
        {
            return new Circle(r);
        }

        public ISquarable CreateTriangle(double a, double b, double c)
        {
            return new Triangle(a, b, c);
        }
    }
}
