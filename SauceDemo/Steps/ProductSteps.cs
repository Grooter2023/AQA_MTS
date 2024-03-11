using Allure.Net.Commons;
using NUnit.Allure.Attributes;
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

        [AllureStep("AddingProductCart")]
        public InventoryPage AddingProductCart()
        {
            AllureLifecycle.Instance.UpdateStep(stepResult =>
         stepResult.parameters.Add(
             new Parameter
             {
                 name = "Started at",
                 value = DateTime.Now.ToString()
             }
         ));

         inventoryPage.AddBackpackButton.Click();

            return InventoryPage;
        }
    }
}
