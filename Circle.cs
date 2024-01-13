using System;

namespace Task_one;

public class Circle : Figure
{
    public double Radius { get; set; }

    // Конструктор 
    public Circle(double radius)
    {
        Radius = radius;
    }

    //Метод для расчета площади
    public override double CalculationArea()
    {
        return Math.PI * Radius * Radius;
    }

    //Метод для расчета периметра (длины окружности) круга
    public override double CalculationPerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}
