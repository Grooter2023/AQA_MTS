using System;

namespace Generics.Task_two;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Укажите:\n1 - автоматическая проверка;\n2-ввод собственных значений");
        string mode = Console.ReadLine();  
        if (mode == "1")
        {
            RunPredefinedTest(); 
        }
        else if (mode == "2")
        {
            RunCustomTest(); 
        }
        else
        {
            Console.WriteLine("Неверно введено значение!"); 
        }
    }
    // метод для тестирования с вводом пользовательских данных
    static void RunCustomTest()
    {
        Console.WriteLine("Укажите начальный размер массива:");
        int size = int.Parse(Console.ReadLine());  
        GenericArray<int> intArray = new GenericArray<int>(size); 
        while (true) 
        {
            Console.WriteLine("Выберите:\n1 - добавить;\n2 - удалить;\n3 - вывести;\n4 - выход\n");
            string action = Console.ReadLine();  
            switch (action)
            {
                case "1": 
                    Console.WriteLine("Укажите значение для добавления:");
                    int valueToAdd = int.Parse(Console.ReadLine());
                    intArray.Add(valueToAdd);
                    break;
                case "2":  
                    Console.WriteLine("Укажите индекс для удаления:");
                    int indexToRemove = int.Parse(Console.ReadLine());
                    try
                    {
                        intArray.RemoveAt(indexToRemove);
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);  
                    }
                    break;
                case "3":  
                    for (int i = 0; i < intArray.Length(); i++)
                    {
                        Console.WriteLine(intArray.Get(i));
                    }
                    break;
                case "4":  
                    return;
                default:  
                    Console.WriteLine("Ввод неверный!");
                    break;
            }
        }
    }
    // метод - автоматической проверки задания с предопределенными значениями
    static void RunPredefinedTest()
    {
        GenericArray<int> intArray = new GenericArray<int>(5);
        intArray.Add(1);
        intArray.Add(2);
        intArray.Add(3);

        Console.WriteLine("Элементы массива до удаления:");
        for (int i = 0; i < intArray.Length(); i++)
        {
            Console.WriteLine(intArray.Get(i));
        }
        intArray.RemoveAt(1);
        Console.WriteLine("Элементы массива после удаления:");
        for (int i = 0; i < intArray.Length(); i++)
        {
            Console.WriteLine(intArray.Get(i));
        }
    }
}