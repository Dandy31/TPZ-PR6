using System;

namespace GeometryLib
{
    /// <summary>
    /// Клас, що описує прямокутник.
    /// </summary>
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Розрахунок площі прямокутника.
        /// </summary>
        public double CalculateArea()
        {
            if (Width <= 0 || Height <= 0) return 0;
            return Width * Height;
        }

        /// <summary>
        /// Розрахунок периметра прямокутника.
        /// </summary>
        public double CalculatePerimeter()
        {
            if (Width <= 0 || Height <= 0) return 0;
            return 2 * (Width + Height);
        }
    }
}