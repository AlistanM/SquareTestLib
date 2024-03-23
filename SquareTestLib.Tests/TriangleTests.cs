using FluentAssertions;
using Xunit;

namespace SquareTestLib.Tests
{
    public class TriangleTests
    {
        private readonly SquarableFactory _sqFactory;
        private const double Precision = 1e-9;

        public TriangleTests()
        {
            _sqFactory = new SquarableFactory();
        }

        [Theory]
        [InlineData(2, 2, 1, 0.9682458366)]
        [InlineData(3, 4, 5, 6)]
        [InlineData(2, 1, 1, 0)]
        public void TriangelSuccessSquareTest(double a, double b, double c, double expected)
        {
            var triangle = _sqFactory.CreateTriangle(a, b, c);
            var s = triangle.GetSquare();
            s.Should().BeApproximately(expected, Precision);
        }

        [Theory]
        [InlineData(1, 1, 100)]
        [InlineData(-2, -2, -2)]
        [InlineData(0, 0, 0)]
        public void TriangelFailSquareTest(double a, double b, double c)
        {
            Action action = () =>
            {
                var triangle = _sqFactory.CreateTriangle(a, b, c);
                var s = triangle.GetSquare();
            };

            action.Should().Throw<Exception>();
        }
    }
}