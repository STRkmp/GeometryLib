
using GeometryLib.Contracts;
using GeometryLib.Entities.Utility;

namespace GeometryLib.Entities
{
    public class Circle : IShape
    {
        private double Radius { get; set; }

        public Circle(double radius)
        {
            ValidateAndThrow(radius);

            Radius = radius; 
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        private void ValidateAndThrow(double radius)
        {
            if (radius is double.NaN || radius < Constants.Eps)
            {
                throw new ArgumentException("Радиус < 0");
            }
        }
    }
}
