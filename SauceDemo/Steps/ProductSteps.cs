using OpenQA.Selenium;
using SauceDemo_PageObject_Steps.Pages;

namespace SauceDemo_PageObject_Steps.Steps
{
    public class ProductSteps : BaseStep
    {
        private InventoryPage inventoryPage;

        public ProductSteps(IWebDriver driver) : base(driver)
        {
            inventoryPage = new InventoryPage(driver, true);
        }
      
        public InventoryPage NavigateToLoginPage()
        {
            return new InventoryPage(Driver, true);
        }

        public InventoryPage AddingProductCart()
        {
            inventoryPage.AddBackpackButton.Click();

            return InventoryPage;
        }
    }
}
