using GeometryLib.Contracts;
using GeometryLib.Entities.Utility;

namespace GeometryLib.Entities
{
    public class Triangle : IShape
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }

        public Triangle(double a, double b, double c) 
        {
            ValidateAndThrow(a, b, c);

            A = a;
            B = b;
            C = c;
        }

        public double GetArea()
        {
            var p = (A + B + C) / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRightTriangle()
        {
            var sides = new[] { A, B, C };

            var squaredSortedSides = sides
                .OrderBy(side => side)
                .Select(side => Math.Pow(side, 2))
                .ToArray();

            return Math.Abs(squaredSortedSides[2] - (squaredSortedSides[1] + squaredSortedSides[0])) < Constants.Eps;
        }

        private void ValidateAndThrow(double a, double b, double c)
        {
            var sides = new[] { a, b, c };
            
            if (sides.Any(side => side is double.NaN || side < Constants.Eps)){
                throw new ArgumentException("Side must be > 0");
            }

            Array.Sort(sides);

            if (sides[0] + sides[1] - sides[2] < Constants.Eps)
            {
                throw new ArgumentException("Wrong sides");
            }
        }
    }
}
