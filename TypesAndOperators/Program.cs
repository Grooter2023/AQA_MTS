// Задание 1
/* 
namespace TypesAndOperators
{
    static class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } ;
            string text = "Ваше число НЕ входит в массив!";

             Console.WriteLine("Введите число ");
             double b = Convert.ToDouble(Console.ReadLine()); // 2
            
            for (int i = 0; i < arr.GetLength(0); i++) 
            {
                if (arr[i] == b)
                {
                    text = "Ваше число входит в массив!";
                    break;
                }            
            }
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
*/

// Задание 2
/* 
namespace TypesAndOperators
{
    static class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            bool fl = false;

            Console.WriteLine("Введите число ");
            double b = Convert.ToDouble(Console.ReadLine()); 

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i] == b)
                {
                    arr[i] = 0;
                    fl = true;
                }
            }
            if (fl)
            {
                foreach (int c in arr)
                {
                    Console.WriteLine(c);
                }
            }
            else
            {
                Console.WriteLine("Ваше число НЕ нашлось!");
            }
            Console.ReadKey();
        }
    }
}
*/


// Задание 3
/* 
namespace TypesAndOperators
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива ");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[a];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0,5);
            }
            string one = string.Join(" ",array);
            Console.WriteLine(one);  

            int min = 0;
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {     
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            double summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                 summ = summ + array[i];   
            }
            double aver = summ / array.Length;
            Console.WriteLine($"Максимальное значение = {max}");
            Console.WriteLine($"Минимальное значение = {min}");
            Console.WriteLine($"Среднее значение = {aver}");
            Console.ReadKey();
        }
    }
}
*/

// Задание 4
/* 
namespace TypesAndOperators
{
    static class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 0, 0, 0, 0, 5 };
            int[] arr2 = { 0, 0, 0, 50, 5 };

            string one = string.Join(" ", arr1);
            Console.WriteLine(one);

            string two = string.Join(" ", arr2);
            Console.WriteLine(two);

            double summ1 = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                summ1 = summ1 + arr1[i];
            }
            double aver1 = summ1 / arr1.Length;

            double summ2 = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                summ2 = summ2 + arr2[i];
            }
            double aver2 = summ2 / arr2.Length;

            Console.WriteLine($"Среднее значение = {aver1}");
            Console.WriteLine($"Среднее значение = {aver2}");

            if (aver1 == aver2)
            {
                Console.WriteLine(" Среднии первого и второго массива равны! ");
            }
            else
            {
                if (aver1 > aver2)
                {
                    Console.WriteLine(" Средняя первого массива больше! ");
                }
                else
                {
                    Console.WriteLine("Средняя второго массива больше!");
                }
            }
        } 
    }
}
*/