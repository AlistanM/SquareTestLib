namespace SquareTestLib.Figures
{
    public class Circle : ISquarable
    {
        private readonly double _radius;
        
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new InvalidOperationException("There is no circle with such radius");
            }

            _radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
