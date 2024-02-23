using OpenQA.Selenium;
using SauceDemo.Core;
using SauceDemo.Helpers.Configuration;

namespace SauceDemo.Helpers;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; set; }

    [SetUp]
    public void SetUp()
    {
        Driver = new Browser().Driver;
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
        IWebElement usernameInput = Driver.FindElement(By.Id("user-name"));
        IWebElement passwordInput = Driver.FindElement(By.Id("password"));
        IWebElement loginButton = Driver.FindElement(By.Id("login-button"));

        usernameInput.SendKeys("standard_user");
        passwordInput.SendKeys("secret_sauce");

        Thread.Sleep(9000);
        loginButton.Click();

        Thread.Sleep(1000);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}