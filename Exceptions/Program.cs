namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Тестирование с предопределенными данными
            Console.WriteLine("Тестирование с предопределенными данными:");
            TestValidation("myLogin", "myP@ssw0rd", "myP@ssw0rd");

            // Тестирование с вводом пользователя
            Console.WriteLine("\nВведите данные для тестирования:");
            Console.Write("Логин: ");
            string login = Console.ReadLine();
            Console.Write("Пароль: ");
            string password = Console.ReadLine();
            Console.Write("Подтверждение пароля: ");
            string confirmPassword = Console.ReadLine();

            bool result = Authentication.ValidateCredentials(login, password, confirmPassword);
            Console.WriteLine($"Результат валидации: {result}");
        }
        //Метод возвращает true, если все значения верны или false в другом случае
        static void TestValidation(string login, string password, string confirmPassword)
        {
            bool result = Authentication.ValidateCredentials(login, password, confirmPassword);
            Console.WriteLine($"Результат валидации: {result}");
        }
    }
}
