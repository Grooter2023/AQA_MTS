using OpenQA.Selenium;
using SauceDemo_PageObject_Steps.Pages;
using SauceDemo_PageObject_Steps.Pages.CheckoutPages;


namespace SauceDemo_PageObject_Steps.Steps
{
    public class BaseStep
    {
        protected IWebDriver Driver;

        public BaseStep(IWebDriver driver)
        {
            Driver = driver;
        }

        public SaucedemoLoginPage SaucedemoLoginPage => new(Driver, true);
        public InventoryPage InventoryPage => new(Driver, true);
        public CartPage CartPage => new(Driver, true);
        public CheckoutOnePage CheckoutOnePage => new(Driver, true);
        public СheckoutTwoPage СheckoutTwoPage => new(Driver, true);
        public CheckoutCompletePage CheckoutCompletePage => new(Driver, true);
    }
}