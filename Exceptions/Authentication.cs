namespace Exceptions
{
    public class Authentication
    {
        public static bool ValidateCredentials(string login, string password, string confirmPassword)
        {
            try
            {
                // Проверка логина
                if (login.Length >= 20 || login.Contains(" "))
                {
                    throw new WrongLoginException("Логин не должен содержать пробелы и быть меньше 20 символов.");
                }

                // Проверка пароля
                if (password.Length >= 20 || password.Contains(" ") || !password.Any(char.IsDigit) || password != confirmPassword)
                {
                    throw new WrongPasswordException("Пароль должен быть меньше 20 символов, содержать хотя бы одну цифру и совпадать с подтверждением.");
                }

                return true;
            }
            catch (WrongLoginException e)
            {
                Console.WriteLine($"Ошибка логина: {e.Message}");
                return false;
            }
            catch (WrongPasswordException e)
            {
                Console.WriteLine($"Ошибка пароля: {e.Message}");
                return false;
            }
        }
    }
}
