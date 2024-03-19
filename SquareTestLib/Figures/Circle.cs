using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareTestLib.Figures
{
    public class Circle : ISquarable
    {
        private readonly double _radius;

        public Circle(double radius) { 
            _radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
