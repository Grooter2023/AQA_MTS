using System;

namespace Task_two;

public class Therapist : Doctor
{

    private string Name;

    // Конструктор класса принимает на вход два параметра для инициализации всех переменных, вызывая базовый конструктов у класса Doctor. 
    public Therapist(string PhoneNumber, string Email) : base(PhoneNumber, Email)

    // Конструктор класса принимает на вход один параметр для инициализации переменной класса - Name.
    public Therapist(string Name) { this.Name = Name }

    //метод лечить;
    public override void Treat()
    {
        base.Treat();// вызов метода Treat из базового класса
        Console.WriteLine("Лечение терапевтом: ....!");
    }
}