using OpenQA.Selenium;
using SauceDemo_PageObject_Steps.Core;
using SauceDemo_PageObject_Steps.Helpers;
using SauceDemo_PageObject_Steps.Helpers.Configuration;
using SauceDemo_PageObject_Steps.Steps;

namespace SauceDemo_PageObject_Steps.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }
    protected SaucedemoLoginSteps NavigationSteps;
    protected ProductSteps ProductSteps;

    [SetUp]
    public void FactoryDriverTest()
    {
        Driver = new Browser().Driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));

        NavigationSteps = new SaucedemoLoginSteps(Driver);
        ProductSteps = new ProductSteps(Driver);
    }


    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}