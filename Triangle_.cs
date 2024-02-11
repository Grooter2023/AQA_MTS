using System;

namespace Task_one;

public class Triangle_ : Figure
{    
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    // Конструктор - стороны
    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }
    // Метод для расчета площади треугольника
    public override double CalculationArea()
    {
        double s = (A + B + C) / 2;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
    }
    // Метод для расчета периметра треугольника
    public override double CalculationPerimeter()
    {
        return A + B + C;
    }
}
