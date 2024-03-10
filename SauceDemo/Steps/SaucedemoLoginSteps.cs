using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using SauceDemo_PageObject_Steps.Pages;


namespace SauceDemo_PageObject_Steps.Steps
{
    public class SaucedemoLoginSteps : BaseStep
    {
        private SaucedemoLoginPage saucedemoLoginPage;

        public SaucedemoLoginSteps(IWebDriver driver) : base(driver)
        {
            saucedemoLoginPage = new SaucedemoLoginPage(driver, true);
        }

        public SaucedemoLoginPage NavigateToLoginPage()
        {
            return new SaucedemoLoginPage(Driver, true);
        }

        [AllureStep("Authorization")]
        public SaucedemoLoginPage Authorization(string username, string password)
        {
                AllureLifecycle.Instance.UpdateStep(stepResult =>
                stepResult.parameters.Add(
                new Parameter
                {
                 name = "Started at",
                 value = DateTime.Now.ToString()
                }
                ));

            saucedemoLoginPage.InputUserName.SendKeys(username);
            saucedemoLoginPage.InputPassword.SendKeys(password);
            saucedemoLoginPage.PressButtonLogin.Click();

            return saucedemoLoginPage;
        }
    }
}
