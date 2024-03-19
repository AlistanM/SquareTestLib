using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareTestLib.Figures
{
    public class Triangle : ISquarable
    {
        private readonly double _a; 
        private readonly double _b; 
        private readonly double _c;

        public Triangle(double a, double b, double c) {
            if (a+b>c && a+c>b && b+c>a)
            {
                _a = a;
                _b = b;
                _c = c;
            }
            else
            {
                throw new InvalidOperationException("There is no triangle with such sides");
            }
        }

        public double GetSquare()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }
    }
}
