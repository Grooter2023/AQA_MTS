// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
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






// Урок 7
/*
if (условие)

{

}    
*/

/*
bool isWhiteBreadFresh = true;
ushort whiteBreadPrice = 150;
ushort butterPrice = 230;
ushort milkPrice = 170;
float milkFatPercentage = 1.2F;
ushort icecreamPrice=350;

Console.WriteLine("Введите начальную сумму: ");
string? sumString = Console.ReadLine();
short sum = Convert.ToInt16(sumString);

if (sum > 0)
{
    Console.WriteLine("Сумма не может быть меньше 0");
}
else
{
    Console.WriteLine("Сумма не может быть меньше 0");
}
}

    

if (isWhiteBreadFresh)
{
    // sum = (short)( sum - whiteBreadPrice);
    sum = Convert.ToInt16(sum - whiteBreadPrice);
}
sum = (short)(sum - butterPrice);

if (milkFatPercentage ==1.2F)
{
    sum = Convert.ToInt16(sum - milkPrice);
}

 if (sum >= icecreamPrice)
{
    sum = Convert.ToInt16(sum - icecreamPrice);
}
Console.WriteLine($"Остаток суммы: {sum}");
}


  else
{
    Console.WriteLine("Сумма не может быть меньше 0");
}
}

*/




