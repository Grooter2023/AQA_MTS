using System;

namespace Delegate.First_task;
class Program  
{
    //Делегат RandomNumberGenerator. Он ссылается на метод GenerateRandomNumber.Не принимает параметров, возвращает тип данных int
    delegate int RandomNumberGenerator();

    private static Random random = new Random();

    static void Main(string[] args)
    {
        RandomNumberGenerator rng = GenerateRandomNumber;

        int result = rng();

        Console.WriteLine("Рандомное число: " + result);
    }

    // Метод GenerateRandomNumber - соответствует сигнатуре делегата RandomNumberGenerator. Не принимает параметров, возвращает тип данных int
    static int GenerateRandomNumber()
    {
        return random.Next(0, 100);
    }
}
