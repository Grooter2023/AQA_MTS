using System;

namespace Task_one;

abstract class Figure // т.к в явном виде не задан модификатор доступа, то он по умолчанию будет internal
{
    //Метод для расчета площади
    public abstract double CalculationArea();

    //Метод для расчета периметра
    public abstract double CalculationPerimeter();
}