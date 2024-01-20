using System;

namespace Task_one;

class Program // т.к в явном виде не задан модификатор доступа, то он по умолчанию будет internal
{
    static void Main()
    {
        // Создание массива фигур
        Figure[] figures = new Figure[5]
        {
            new Triangle(3, 4, 5),
            new Rectangle(6, 10),
            new Circle(10),
            new Triangle(6, 6, 6),
            new Rectangle(7, 10)
        }

        // Для суммы периметров и площадей переменные
        double Area = 0;
        double Perimeter = 0;

        // Вычисление общей площади и периметра
        foreach (Figure figure in figures)
        {
            Area += figure.CalculationArea();
            Perimeter += figure.CalculationPerimeter();
        }

        // Вывод на консоль суммы периметров и площади всех фигур в массиве
        Console.WriteLine($"Общая площадь фигур: {Area}");
        Console.WriteLine($"Общий периметр фигур: {Perimeter}");
    }
}
