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

        public SaucedemoLoginPage Authorization(string username, string password)
        {
            saucedemoLoginPage.InputUserName.SendKeys(username);
            saucedemoLoginPage.InputPassword.SendKeys(password);
            saucedemoLoginPage.PressButtonLogin.Click();

            return saucedemoLoginPage;
        }
    }
}
