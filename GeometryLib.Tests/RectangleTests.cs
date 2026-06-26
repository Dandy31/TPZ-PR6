using GeometryLib;
using System.Drawing;
using Xunit;

namespace GeometryLib.Tests
{
    public class RectangleTests
    {
        [Fact]
        public void CalculateArea_ValidPositiveValues_ReturnsCorrectArea()
        {
            var rectangle = new Rectangle(5.0, 4.0);

            double result = rectangle.CalculateArea();

            Assert.Equal(20.0, result);
        }

        [Fact]
        public void CalculateArea_WithZeroWidth_ReturnsZero()
        {
            var rectangle = new Rectangle(0, 10.0);

            double result = rectangle.CalculateArea();

            Assert.Equal(0, result);
        }

        [Fact]
        public void CalculateArea_WithNegativeValues_ReturnsZero()
        {
            var rectangle = new Rectangle(-5.0, 4.0);

            double result = rectangle.CalculateArea();

            Assert.Equal(0, result);
        }

        [Fact]
        public void CalculatePerimeter_ValidPositiveValues_ReturnsCorrectPerimeter()
        {
            var rectangle = new Rectangle(5.0, 4.0);

            double result = rectangle.CalculatePerimeter();

            Assert.Equal(18.0, result);
        }

        [Fact]
        public void CalculatePerimeter_WithZeroHeight_ReturnsZero()
        {
            var rectangle = new Rectangle(5.0, 0);

            double result = rectangle.CalculatePerimeter();

            Assert.Equal(0, result);
        }

        [Fact]
        public void CalculatePerimeter_LargeValues_ReturnsCorrectPerimeter()
        {
            var rectangle = new Rectangle(1000.0, 2000.0);

            double result = rectangle.CalculatePerimeter();

            Assert.Equal(6000.0, result);
        }
    }
}