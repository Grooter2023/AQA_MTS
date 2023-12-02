using Classes.Task_two;

namespace Classes.Task_two
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard firstCard = new CreditCard(100100100, 100);
            CreditCard secondCard = new CreditCard(100100101, 100);
            CreditCard thirdCard = new CreditCard(100100102, 100);


            firstCard.enrollment(10);
            secondCard.enrollment(10);
            thirdCard.withdrawal(50);

            firstCard.print();
            secondCard.print();
            thirdCard.print();


            Console.ReadLine();
        }
    }
}