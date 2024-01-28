namespace Generics.Task_one;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координат X:");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите координату Y:");
        int y = int.Parse(Console.ReadLine());

        Point point = new Point(x, y); // создание объекта класса Point и инициализация его координат
        point.Display();
    }
}