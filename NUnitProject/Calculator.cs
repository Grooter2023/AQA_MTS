using NUnitTest;

namespace NUnitTest
{
    public class Calculator
    {
        //конструктор без параметров
        public Calculator()
        {
        }

        //метод Div  int
        public int Div(int a, int b)
        {
            if (b == 0)
                throw new ArgumentException("Cannot divide by zero!");
            return a / b;
        }

        //метод Div double
        public double Div(double a, double b)
        {
            if (b == 0)
                throw new ArgumentException("Cannot divide by zero!");
            return a / b;
        }
    }
}