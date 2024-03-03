using SeleniumBasic.Helpers.Configuration;
using SeleniumBasic.Pages;

namespace SeleniumBasic.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        // Простой вид
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.SuccessFulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        DashboardPage dashboardPage = new DashboardPage(Driver);

        // Проверка 
        Assert.That(dashboardPage.IsPageOpened);
    }

    [Test]
    public void InvalidUsernameLoginTest()
    {
        // Проверка
        Assert.That(
            new LoginPage(Driver)
                .IncorrectLogin("ssdd", "") // метод возвращает экземпляр логин страницы
                .ErrorLabel.Text.Trim(),//ожидаем на странице элемент ErrorLabel в котором мы получаем значение
            Is.EqualTo("Email/Login or Password is incorrect. Please try again.")); // сравниваем с ожиданием 
    }
}