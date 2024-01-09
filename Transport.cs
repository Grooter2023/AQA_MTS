using System;

class Transport
{
    public string Destination { get; set; }  
    public int Number { get; set; }  
    public TimeSpan DepartureTime { get; set; }  
    public int Place { get; set; }  

    // Конструктор
    public Transport(string destination, int number, TimeSpan departureTime, int place)
    {
        Destination = destination;
        Number = number;
        DepartureTime = departureTime;
        Place = place;
    }

    // Виртуальный метод для получения типа транспорта
    public virtual string GetTransportType()
    {
        return "Совокупный транспорт";
    }
}