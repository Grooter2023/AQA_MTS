using OpenQA.Selenium;
using SeleniumBasic.Core;

namespace SeleniumBasic.Tests;
// Для запуска в параллель тестов
[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]

public class BaseTest
{
    protected IWebDriver Driver { get; set; }

    [SetUp]
    public void FactoryDriverTest()
    {
        Driver = new Browser().Driver;
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }

}