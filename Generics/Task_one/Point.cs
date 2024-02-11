using System;

namespace Generics.Task_one;

class Point
{
    private int x;  
    private int y;  

    // конструктор для инициализации координат X и Y
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    // свойство для доступа к координате Y
    public int Y
    {
        get { return y; }
        set { y = value; }
    }

    // свойство для доступа к координате X
    public int X
    {
        get { return x; }
        set { x = value; }
    }

    // метод для вывода координат точки
    public void Display()
    {
        Console.WriteLine($"Точка на плоскости: X = {x}, Y = {y}");
    }
}