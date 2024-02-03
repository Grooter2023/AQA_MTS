using System;

namespace LINQ.Third_homework;

class Program
{
    static void Main()
    {
        List<string> strings = new List<string>
        {
            "A", "B", "AB", "C", "ABC", "D"
        };

        // Cортировка строк
        var sortedStrings = strings
            .GroupBy(s => s.Length)  
            .Select(g => g.OrderByDescending(s => s))  
            .SelectMany(g => g)  
            .OrderBy(s => s.Length)  
            .ThenByDescending(s => s);  

        Console.WriteLine("Отсортированная последовательность:");
        foreach (var str in sortedStrings)
        {
            Console.WriteLine(str); 
        }
    }
}