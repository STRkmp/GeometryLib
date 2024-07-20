using GeometryLib.Entities;

namespace Tests
{
    public class ShapeTests
    {
        private const int Precision = 3;

        [Theory]
        [InlineData(5.0, 78.5398)]
        [InlineData(2.0, 12.5664)]
        public void Circle_GetArea_ReturnsCorrectArea(double radius, double expectedArea)
        {
            var circle = ShapeFactory.CreateCircle(radius);
            
            var resultArea = circle.GetArea();

            Assert.Equal(expectedArea, resultArea, precision: Precision);
        }

        [Theory]
        [InlineData(0.0)]
        [InlineData(double.NaN)]
        [InlineData(-1)]
        public void Circle_WrongRadius_ReturnsException(double radius)
        {
            Assert.Throws<ArgumentException>(() => ShapeFactory.CreateCircle(radius));
        }

        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(41, 54, 18, 290.329)]
        [InlineData(14.3, 18.56, 18, 120.197)]
        public void Triangle_GetArea_ReturnsCorrectArea(double A, double B, double C, double expectedArea)
        {
            var triangle = ShapeFactory.CreateTriangle(A, B, C);

            var resultArea = triangle.GetArea();

            Assert.Equal(expectedArea, resultArea, precision: Precision);
        }

        [Theory]
        [InlineData(3, 4, 16)]
        [InlineData(double.NaN, 4, 5)]
        [InlineData(-1, 1 , 3)]
        [InlineData(0, 3, 5)]
        public void Triangle_WrongSides_ReturnsException(double A, double B, double C)
        {
            Assert.Throws<ArgumentException>(() => ShapeFactory.CreateTriangle(A, B, C));
        }

        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(5, 12, 13)]
        [InlineData(8, 15, 17)]
        public void Triangle_IsRightTriangle_ReturnsTrue(double A, double B, double C)
        {
            var triangle = ShapeFactory.CreateTriangle(A, B, C);

            if (triangle is not Triangle)
                throw new Exception("It's not Triangle");

            var result = ((Triangle)triangle).IsRightTriangle();

            Assert.True(result);
        }

        [Theory]
        [InlineData(3, 4, 6)]
        [InlineData(7, 10, 12)]
        [InlineData(5, 5, 8)]
        public void Triangle_IsRightTriangle_ReturnsFalse(double A, double B, double C)
        {
            var triangle = ShapeFactory.CreateTriangle(A, B, C);


            if (triangle is not Triangle)
                throw new Exception("It's not Triangle");
            
            var result = ((Triangle)triangle).IsRightTriangle();

            Assert.False(result);
        }

    }
}