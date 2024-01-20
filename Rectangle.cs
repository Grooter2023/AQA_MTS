using System;

namespace Task_one;

public class Rectangle : Figure
{
    public double Width { get; set; }
    public double Height { get; set; }

    // Конструктор 
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    // Метод для расчета площади треугольника
    public override double CalculationArea()
    {
        return Width * Height;
    }

    // Метод для расчета периметра треугольника
    public override double CalculationPerimeter()
    {
        return 2 * (Width + Height);
    }
}
