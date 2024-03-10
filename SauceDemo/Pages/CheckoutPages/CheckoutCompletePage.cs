using OpenQA.Selenium;

namespace SauceDemo_PageObject_Steps.Pages.CheckoutPages

{
    public class CheckoutCompletePage : BasePage
    {
        private static string END_POINT = "/checkout-complete.html";

        private static readonly By CheckoutСompleteBy = By.XPath("//*[@class='title' and text()='Checkout: Complete!']");
        private static readonly By CompleteHeaderBy = By.ClassName("complete-header");
        private static readonly By CompleteTextBy = By.ClassName("complete-text");
        private static readonly By BackToProductsButtonBy = By.Id("back-to-products");

        public CheckoutCompletePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
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
                return CompleteHeader.Text.Trim().Equals("Thank you for your order!");
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool IsCompleteHeaderDisplayed() => CompleteHeader.Displayed;

        public IWebElement CheckoutСomplete => WaitsHelper.WaitForExists(CheckoutСompleteBy);
        public IWebElement CompleteHeader => WaitsHelper.WaitForExists(CompleteHeaderBy);
        public IWebElement CompleteText => WaitsHelper.WaitForExists(CompleteTextBy);
        public IWebElement BackToProductsButton => WaitsHelper.WaitForExists(BackToProductsButtonBy);
    }
}