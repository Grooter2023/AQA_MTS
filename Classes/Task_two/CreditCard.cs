using Classes.Task_two;

namespace Classes.Task_two;

public class CreditCard
{
    public int accountNumber; // номер счета
    public double currentAmountAccount; // текущая сумма на счету.

    public CreditCard(double currentAmountAcc, int accountNum) 
    {
        currentAmountAccount = currentAmountAcc;
        accountNumber = accountNum;
    }
 
    //метод который позволяет зачислять сумму на кредитную карту;
    public void enrollment(double plusAmount)
    {
        currentAmountAccount += plusAmount;
    }

    //метод который позволяет снимать некоторую сумму с карты
    public double withdrawal(double munisAmount)
    {
        currentAmountAccount -= munisAmount;
        return munisAmount;
    }
    //который выводит текущую информацию о карточке
    public void print() => Console.WriteLine($"Номер счета: {accountNumber}  Tекущая сумма на счету: {currentAmountAccount}");
}