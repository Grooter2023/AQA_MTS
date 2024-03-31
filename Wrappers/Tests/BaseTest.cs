using Allure.Net.Commons;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using Patterns.Core;
using System.Text;
using Patterns.Steps;
using Patterns.Helpers;
using Patterns.Helpers.Configuration;

namespace Patterns.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
[AllureNUnit]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }
    protected SCFStep _sCFStep;
    protected AldrethScaleStep _aldrethScaleStep;
    protected DaysCalendarStep _daysCalendarStep;


    [OneTimeSetUp]
    public static void GlobalSetup()
    {
        AllureLifecycle.Instance.CleanupResultDirectory();
    }

    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));

        _sCFStep = new SCFStep(Driver);
        _aldrethScaleStep = new AldrethScaleStep(Driver);
        _daysCalendarStep = new DaysCalendarStep(Driver);

        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        try
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                byte[] screenshotBytes = screenshot.AsByteArray;

                AllureApi.AddAttachment(
                    "data.txt",
                    "text/plain",
                    Encoding.UTF8.GetBytes("This is the file content.")
                );
                AllureApi.AddAttachment(
                    "Screenshot",
                    "image/png",
                    screenshotBytes
                );
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        Driver.Quit();
    }
}