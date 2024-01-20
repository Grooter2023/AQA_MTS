using System;

namespace Task_two;

public class Doctor
{
    private string PhoneNumber;
    private string Email;
    
    // Конструктор класса принимает на вход два параметра для инициализации всех переменных класса Doctor. 
    public Doctor(string PhoneNumber, string Email) : this(PhoneNumber, Email)
    { 
        this.PhoneNumber = PhoneNumber;
        this.Email = Email;
    }

    //метод лечить;
    public void Treat()
    {
        Console.WriteLine("Лечение универсальным врачом!");
    }
}
