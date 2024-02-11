using System;

namespace Generics.Task_two;

class GenericArray<T>
{
    private T[] array; 
    private int size; 
    // конструктор - инициализация массива с заданной начальной емкостью
    public GenericArray(int initialCapacity)
    {
        array = new T[initialCapacity];  
        size = 0;  
    }
    // метод - добавление элемента в массив
    public void Add(T item)
    {
        if (size == array.Length) 
        {
            Array.Resize(ref array, array.Length * 2);  
        }
        array[size] = item;  
        size++;  
    }
    // метод - удаление элемента из массива по индексу
    public void RemoveAt(int index)
    {
        if (index >= 0 && index < size)  
        {
            for (int i = index; i < size - 1; i++)  
            {
                array[i] = array[i + 1];
            }

            array[size - 1] = default(T);  
            size--;  
        }
        else  
        {
            throw new IndexOutOfRangeException("Индекс вне допустимого диапазона!");
        }
    }
    // метод - получение элемента из массива по индексу
    public T Get(int index)
    {
        if (index >= 0 && index < size)  
        {
            return array[index];  
        }
        else  
        {
            throw new IndexOutOfRangeException("Индекс вне допустимого диапазона!");
        }
    }
    // метод - получение текущего размера массива
    public int Length()
    {
        return size;  
    }
}