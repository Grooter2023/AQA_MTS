using System;

namespace Task_two;

public class Surgeon : Doctor
{

    private string Name;

    // Конструктор класса принимает на вход два параметра для инициализации всех переменных, вызывая базовый конструктов у класса Doctor. 
    public Surgeon(string PhoneNumber, string Email) : base(PhoneNumber, Email)

    // Конструктор класса принимает на вход один параметр для инициализации переменной класса - Name.
    public Surgeon(string Name) { this.Name = Name }
    
    //метод лечить;
    public override void Treat()
    {
        base.Treat();// вызов метода Treat из базового класса
        Console.WriteLine("Лечение хирургом: ....!");
    }
}