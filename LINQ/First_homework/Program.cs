using System; 

namespace LINQ.First_homework;

class Program
{
    static void Main()
    {
        int[] sequence = { 1, 3, 5, 7, 9, 3, 5, 2, 4, 6, 8, 10 };

        // Фильтруются нечетные числа и удаляются повторяющиеся элементы.
        var filteredSequence = sequence
            .Where(x => x % 2 != 0)  
            .GroupBy(x => x)  
            .Select(g => g.First());  

        // Отображение отфильтрованной последовательности
        Console.WriteLine("Отфильтрованная последовательность: ");
        foreach (var num in filteredSequence)
        {
            Console.WriteLine(num);  
        }
    }
}

