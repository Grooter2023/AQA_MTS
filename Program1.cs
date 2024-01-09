using System;

public class Program1
{
    static void Main()
    {
        // Создание объекта класса Bus
        Bus bus = new Bus("Вокзал", 5, new TimeSpan(20, 40, 0), 40);
        Console.WriteLine($"Автобус: Пункт назначения={bus.Destination}, Номер={bus.Number}, Время отправления={bus.DepartureTime}, Кол-во мест={bus.Place}");

        // Создание массива транспорта
        Transport[] transports = new Transport[]
        {
            bus, new Trolleybus("Ленина", 6, new TimeSpan(10, 30, 0), 30),
            new Tramcar("Мира", 109, new TimeSpan(30, 30, 0), 50)
        };

        // Сортировка транспорта по количеству мест
        Array.Sort(transports, (t1, t2) => t1.Place.CompareTo(t2.Place));

        // Вывод отсортированного списка транспорта
        Console.WriteLine("Отсортированный список транспорта по количеству мест:");
        foreach (var transport in transports)
        {
            Console.WriteLine($"{transport.GetTransportType()}: Пункт назначения={transport.Destination}, Номер={transport.Number}, Время отправления={transport.DepartureTime}, Число мест={transport.place}");
        }

        // Запрос данных у пользователя
        Console.Write("Введите время отправления (чч:мм): ");
        TimeSpan userTime = TimeSpan.Parse(Console.ReadLine());
        Console.Write("Введите пункт назначения: ");
        string userDestination = Console.ReadLine();

        // Поиск и вывод транспорта, соответствующего параметрам
        var foundTransport = transports.FirstOrDefault(t => t.DepartureTime == userTime && t.Destination.Equals(userDestination, StringComparison.OrdinalIgnoreCase));
        if (foundTransport != null)
        {
            Console.WriteLine($"Найденный транспорт: {foundTransport.GetTransportType()}, Номер={foundTransport.Number}");
        }
        else
        {
            Console.WriteLine("Транспорт не найден!");
        }
    }
}
