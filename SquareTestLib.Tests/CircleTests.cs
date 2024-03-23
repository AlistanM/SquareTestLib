using FluentAssertions;
using Xunit;

namespace SquareTestLib.Tests
{
    public class CircleTests
    {
        private readonly SquarableFactory _sqFactory;
        private const double Precision = 1e-9;

        public CircleTests()
        {
            _sqFactory = new SquarableFactory();
        }

        [Theory]
        [InlineData(5, 78.53981633974483)]
        [InlineData(1, 3.141592653589793)]
        public void CircleSuccessSquareTest(double r, double expected)
        {
            var circle = _sqFactory.CreateCircle(r);
            var s = circle.GetSquare();
            s.Should().BeApproximately(expected, Precision);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-5)]
        public void CircleFailSquareTest(double r)
        {
            Action action = () =>
            {
                var circle = _sqFactory.CreateCircle(r);
                var s = circle.GetSquare();
            };

            action.Should().Throw<Exception>();
        }
    }
}
