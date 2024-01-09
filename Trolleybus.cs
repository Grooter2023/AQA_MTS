using System;

class Trolleybus : Transport
{
    // Конструктор 
    public Trolleybus(string destination, int number, TimeSpan departureTime, int place) : base(destination, number, departureTime, place) 
    { 
    }

    // Переопределение метода для получения типа транспорта
    public override string GetTransportType()
    {
        return "Тролейбус";
    }
}