using System;

namespace Task_three;

class Tramcar : Transport
{
    // Конструктор
    public Tramcar(string destination, int number, TimeSpan departureTime, int place) : base(destination, number, departureTime, place) 
    { 
    }

    // Переопределение метода для получения типа транспорта
    public override string GetTransportType()
    {
        return "Трамвай";
    }
}
