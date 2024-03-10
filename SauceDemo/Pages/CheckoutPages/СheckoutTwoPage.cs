using OpenQA.Selenium;
using SauceDemo_PageObject_Steps.Pages;

namespace SauceDemo_PageObject_Steps.Pages.CheckoutPages
{
    public class СheckoutTwoPage : BasePage
    {
        private static string END_POINT = "/checkout-step-two.html";

        private static readonly By CheckoutOverviewBy = By.XPath("//*[@class='title' and text()='Checkout: Overview']");
        private static readonly By СartQuantityBy = By.ClassName("cart_quantity");
        private static readonly By InventoryItemPriceBy = By.XPath("//*[@class='inventory_item_price']");
        private static readonly By TotalBy = By.ClassName("inventory_item_price");
        private static readonly By FinishButtonBy = By.Id("finish");
        private static readonly By CancelButtonBy = By.Id("cancel");

        public СheckoutTwoPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            try
            {
                return CheckoutOverview.Text.Trim().Equals("Checkout: Overview"); ;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IWebElement CheckoutOverview => WaitsHelper.WaitForExists(CheckoutOverviewBy);
        public IWebElement СartQuantity => WaitsHelper.WaitForExists(СartQuantityBy);
        public IWebElement InventoryItemPrice => WaitsHelper.WaitForExists(InventoryItemPriceBy);
        public IWebElement Total => WaitsHelper.WaitForExists(TotalBy);
        public IWebElement FinishButton => WaitsHelper.WaitForExists(FinishButtonBy);
        public IWebElement CancelButton => WaitsHelper.WaitForExists(CancelButtonBy);
    }
}
