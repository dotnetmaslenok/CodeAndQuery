using FigureAreaCalculator.Figures;

namespace FigureAreaCalculator
{
    public static class AreaCalculator
    {
        public static double CalculateCircleArea(double radius)
        {
            return new Circle(radius).CalculateArea();
        }

        public static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            return new Triangle(sideA, sideB, sideC).CalculateArea();
        }
    }
}
