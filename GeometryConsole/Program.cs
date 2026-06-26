using GeometryLib;
using System;

namespace GeometryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Демонстрація роботи GeometryLib");

            Rectangle rect = new Rectangle(5.0, 4.0);

            Console.WriteLine($"Ширина: {rect.Width}, Висота: {rect.Height}");
            Console.WriteLine($"Обчислена площа: {rect.CalculateArea()}");
            Console.WriteLine($"Обчислений периметр: {rect.CalculatePerimeter()}");
        }
    }
}