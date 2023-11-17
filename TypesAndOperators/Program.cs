// Задание 1
/* 
namespace TypesAndOperators
{
    static class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите первое число ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите операцию +, -, *,/");
            string b = Console.ReadLine();

            Console.WriteLine("Введите второе число ");
            double c = Convert.ToDouble(Console.ReadLine());

            switch (b)
            {
                case "+":
                    Console.WriteLine(a + c);
                    break;
                case "-":
                    Console.WriteLine(a - c);
                    break;
                case "/":
                    if (c != 0)
                        Console.WriteLine(a / c);
                    else
                        Console.WriteLine("Нельзя делить на 0!");
                    break;
                case "*":
                    Console.WriteLine(a * c);
                    break;
            }
            Console.ReadKey();
        }
    }
}
*/

//Задание 2
/* 
namespace TypesAndOperators
{
    static class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите целое число ");
            int a = Convert.ToInt32(Console.ReadLine());


            if (a >= -50 && a <= 50)
            {
                if (a >= -40 && a <= -10)
                {
                    Console.WriteLine("[-40 - -10]");
                }
                else
                {
                    if (a >= -9 && a <= 0)
                    {
                        Console.WriteLine("[-9 - 0]");
                    }
                    else
                    {
                        if (a >= 1 && a <= 10)
                        {
                            Console.WriteLine("[1 - 10]");
                        }
                        else
                        {
                            if (a >= 11 && a <= 40)
                            {
                                Console.WriteLine("[11 - 40]");
                            }
                            else
                            {
                                Console.WriteLine("Введено число, не входящее ни в один из имеющихся числовых промежутков!");
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Введено число, не входящее в промежуток (от -50 до 50) !");
            }

            Console.ReadKey();
        }
    }
}
*/

//Задание 3
/* 
namespace TypesAndOperators
{
    static class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите одно из слов, на русском языке: холодно,тепло,прохладно,солнечно,безоблачно,облачно,дождливо,гроза,молния");
            string a = Console.ReadLine();

            switch (a)
            {
                case "холодно":
                    Console.WriteLine("cold");
                    break;
                case "тепло":
                    Console.WriteLine("warm");
                    break;
                case "прохладно":
                    Console.WriteLine("chilly");
                    break;
                case "солнечно":
                    Console.WriteLine("sunny");
                    break;
                case "безоблачно":
                    Console.WriteLine("cloudless");
                    break;
                case "облачно":
                    Console.WriteLine("cloudy");
                    break;
                case "дождливо":
                    Console.WriteLine("rainy");
                    break;
                case "гроза":
                    Console.WriteLine("thunderstorm");
                    break;
                case "молния":
                    Console.WriteLine("lightning");
                    break;

                default:
                    Console.WriteLine("Введено несуществующее слово!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
*/


//Задание 4
// Вариант 1 через IF 
/* 
namespace TypesAndOperators
{
    static class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите целое число ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = a % 2;
            bool c = b == 0;

            if (c)
            {
                Console.WriteLine("Перед Вами четное число!");
            }
            else
            {
                Console.WriteLine("Перед Вами НЕ четное число!");
            }
        
        Console.ReadKey();
        }
    }
}
*/

//Вариант 1.1 через IF 
/* 
namespace TypesAndOperators
{
    static class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите целое число ");
            double a = Convert.ToDouble(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Перед Вами четное число!");
            }
            else
            {
                Console.WriteLine("Перед Вами НЕ четное число!");
            }

            Console.ReadKey();
        }
    }
}
*/


// Вариант 2 через switch
/* 
namespace TypesAndOperators
{
    static class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите целое число ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = a % 2;
            bool c = b == 0;

            switch (c)
            {
                case true:
                    Console.WriteLine("Перед Вами четное число!");
                    break;

                default:
                    Console.WriteLine("Перед Вами НЕ четное число!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
*/


//Вариант 2.1 через switch
/* 
namespace TypesAndOperators
{
    static class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите целое число ");
            double a = Convert.ToDouble(Console.ReadLine());

            switch (a % 2) 
            {
                case 0:
                    Console.WriteLine("Перед Вами четное число!");
                    break;

                default:
                    Console.WriteLine("Перед Вами НЕ четное число!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
*/



// Вариант 3 через тернарный оператор
/* 
namespace TypesAndOperators
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число ");
            double a = Convert.ToDouble(Console.ReadLine());

            string b = 0 == a % 2 ? "Перед Вами четное число!" : "Перед Вами НЕ четное число!";

            Console.WriteLine(b) ;
        
            Console.ReadKey();
        }
}
}
*/


//Доп. задания

// Задание №1
/* 
double pi = 3.141592653;
decimal e = 2.718281828459045M;
Console.WriteLine($"Число Архимеда pi={pi} \nЧисло Эйлера е={e}");
Console.WriteLine("Нажми Enter");
Console.ReadLine();
*/

/* 
// Задание №2
string name0;
string name1;
string name2;

name0 = "\nмоя строка 1"; // \n - Новая строка (перевод строки)
Console.WriteLine(name0);

name1 = "\tмоя строка 2"; // \t - Горизонтальная табуляция
Console.WriteLine(name1);

name2 = "\aмоя строка 3"; // \a - ???
Console.WriteLine(name2);
Console.WriteLine("Нажми Enter");
Console.ReadLine();
*/

/* 
// Задание №3
const double PI = 3.141592653;

Console.WriteLine($"Число PI={PI} \nВведите значение r" );
double r = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(PI * Math.Pow(r, 2));
Console.WriteLine("Ты молодец!");
Console.ReadLine();
*/


/* 
// Задание №4
const double PI = 3.141592653;

Console.WriteLine("Введите значение r");
double r = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\nВведите значение h");
double h = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Число PI={PI} \nЧисло r={r} \nЧисло h={h}");

Console.WriteLine("V = PIR2h");
Console.WriteLine(PI * Math.Pow(r, 2) * h);
Console.WriteLine("S = 2PIR(R + h)");
Console.WriteLine(2 * PI * r * (r + h));

Console.WriteLine("Ты молодец!");
Console.ReadLine();
*/


