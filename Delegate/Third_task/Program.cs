using System;
namespace Delegate.Third_task;

class Program
{
    //Делегат SortAlgorithm. Он ссылается на метод GenerateRandomArray И GetSortAlgorithm. Имеет входной параметр типа int[], возвращает значение с типом данных int
    delegate int[] SortAlgorithm(int[] array);

    // Перечисление для определения типов сортировки
    enum SortType
    {
        BubbleSort, 
        InsertionSort 
    }

    static void Main(string[] args)
    {
       
        int[] array = GenerateRandomArray(3);

        SortType sortType = SortType.BubbleSort;

        SortAlgorithm sortAlgorithm = GetSortAlgorithm(sortType);

        // Процесс сортировки и получение отсортированного массива
        int[] sortedArray = sortAlgorithm(array);

        Console.WriteLine("Отсортированный массив: " + string.Join(", ", sortedArray));
    }

    // Метод GenerateRandomArray - генерация случайного массива заданного размра
    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random(); 
        int[] array = new int[size]; 
        for (int i = 0; i < size; i++) 
        {
            array[i] = random.Next(50); 
        }
        return array; 
    }

    // Метод GetSortAlgorithm - получение соответствующего алгоритма сортировки
    static SortAlgorithm GetSortAlgorithm(SortType sortType)
    {
        switch (sortType) // Определение типа сортировки
        {
            case SortType.BubbleSort:
                return BubbleSort; // Возвращение метода пузырьковой сортировки
            case SortType.InsertionSort:
                return InsertionSort; // Возвращение метода сортировки вставками
            default:
                throw new ArgumentException("Неизвестный тип сортировки"); // Исключение для неизвестного типа сортировки
        }
    }

    // Метод BubbleSort - сортировка пузырьком
    static int[] BubbleSort(int[] array)
    {
        int temp;  
        for (int i = 0; i < array.Length - 1; i++)  
        {
            for (int j = 0; j < array.Length - i - 1; j++)  
            {
                if (array[j] > array[j + 1])  
                {
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        return array;  
    }

    // Метод InsertionSort - сортировка вставками
    static int[] InsertionSort(int[] array)
    {
        int key, j;  
        for (int i = 1; i < array.Length; i++)  
        {
            key = array[i];  
            j = i - 1;
            
            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;  
        }
        return array;  
    }
}
