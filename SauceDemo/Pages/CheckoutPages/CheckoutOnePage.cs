using OpenQA.Selenium;

namespace SauceDemo_PageObject_Steps.Pages.CheckoutPages
{
    public class CheckoutOnePage : BasePage
    {
        private static string END_POINT = "/checkout-step-one.html";

        private static readonly By CheckoutYourInformationBy = By.XPath("//*[@class='title' and text()='Checkout: Your Information']");
        private static readonly By InputFirstnameBy = By.Id("first-name");
        private static readonly By InputLastnameBy = By.Id("last-name");
        private static readonly By InputPostalCodeBy = By.Id("postal-code");
        private static readonly By ContinueButtonBy = By.Id("continue");

        public CheckoutOnePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
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
                return InputFirstname.Displayed && InputLastname.Displayed && InputPostalCode.Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IWebElement CheckoutYourInformation => WaitsHelper.WaitForExists(CheckoutYourInformationBy);
        public IWebElement InputFirstname => WaitsHelper.WaitForExists(InputFirstnameBy);
        public IWebElement InputLastname => WaitsHelper.WaitForExists(InputLastnameBy);
        public IWebElement InputPostalCode => WaitsHelper.WaitForExists(InputPostalCodeBy);
        public IWebElement ContinueButton => WaitsHelper.WaitForExists(ContinueButtonBy);
    }
}
