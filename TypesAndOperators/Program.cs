// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Xml.Linq;
/*
{
    // Это сообщение будет выведено на экран
    /* Многострочный 
     * вид
     * клмментария
      */
/*
    Console.WriteLine("Hello, World!");
    {     
        Console.WriteLine("It's a nice day!");
    }
    const int MINUTES_IN_HOUR = 60;

    string name;

    name = "Bob";
    Console.WriteLine(name);
    
    name = "Bob1";
    Console.WriteLine(name);

    name = "Bob2";
    Console.WriteLine(name);

    Console.WriteLine(true); // логические литералы
    Console.WriteLine(false);// логические литералы


    Console.WriteLine(-10); // целочисленные литералы
    Console.WriteLine(0);// целочисленные литералы
    Console.WriteLine(10);// целочисленные литералы
    Console.WriteLine(0b10011);// целочисленные литералы


    Console.WriteLine(1.24); // дробное
    Console.WriteLine(1.24F);// число с дробной точкой вещественый

    // Console.WriteLine(null); 
    
    Console.WriteLine("It's a \t nice day!");// \t - табуляция
    Console.WriteLine("It's a \n nice day!");// \n - перенос на новую строку
    Console.WriteLine("It's a \\ nice day!");// \\ указание слеша в тексте

    bool flag = true;
    flag = false;

    sbyte sb = 100;

    float a = 3.14F;
    float a1 = 3.14F;

    decimal c = 1005.5M;
    decimal c1 = 1005.5M;

    var d = 10;
    var d1 = 10.2F;

    int j;
    j = 20;

    var j1 = 20; // верное указание 
}
    */

/* 
Console.WriteLine("Добро пожаловать в С#");
Console.Write("Надеюсь Вы ");
Console.Write("постигните нюансы в С#! ");
Console.WriteLine("И все будет супер гуд!!!");
*\

/*
int j;
j = 20;

Console.WriteLine("J = " + j);// конкатинация!!

string name = "Tom";
int age = 34;
double height = 1.7;

Console.WriteLine($"Имя: {name} Возраст {age} Рост:{height}");Console.WriteLine("J = " + j);
Console.WriteLine($"Имя: {0} Возраст {2} Рост:{1}, name , height, age"); Console.WriteLine("J = " + j);
*/

/*
Console.WriteLine("Введите свое имя:");
string? name = Console.ReadLine();
Console.WriteLine($"Ваше имя: {name}");

Console.WriteLine("Введите свой возраст:");
string? age_str = Console.ReadLine();
int age = Convert.ToInt32(age_str);
Console.WriteLine($"Ваш возраст: {age}");
*/


/* 
//Решение нашей задачи
// Подготовка данных

bool isWhiteBreadFresh = true;
ushort whiteBreadPrice = 100;
ushort butterPrice = 230;
ushort milkPrice = 170;
float milkFatPercentage = 1.2F;
}
*/



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