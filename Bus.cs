using System;

class Bus : Transport
{
    // Конструктор
    public Bus(string destination, int number, TimeSpan departureTime, int place) : base(destination, number, departureTime, place) 
    { 
    }
   
    // Переопределение метода для получения типа транспорта
    public override string GetTransportType()
    {
        return "Автобус";
    }
}
