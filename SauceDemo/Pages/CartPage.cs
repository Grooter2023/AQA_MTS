using OpenQA.Selenium;

namespace SauceDemo_PageObject_Steps.Pages
{
    public class CartPage : BasePage
    {
        private static string END_POINT = "cart.html";

        private static readonly By TitleLabelBy = By.ClassName("title");
        private static readonly By ItemLabelBy = By.ClassName("inventory_item_name");
        private static readonly By RemoveButtonBy = By.Id("remove-sauce-labs-backpack");
        private static readonly By ShoppingCartBadgeBy = By.XPath("//span[@class='shopping_cart_badge']");
        private static readonly By CheckoutButtonBy = By.Id("checkout");

        public CartPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            return TitleLabel.Text.Trim().Equals("Your Cart");
        }

        public void ClickRemoveButton() => RemoveButton.Click();

        public IWebElement TitleLabel => WaitsHelper.WaitForExists(TitleLabelBy);
        public IWebElement ItemLabel => WaitsHelper.WaitForExists(ItemLabelBy);
        public IWebElement RemoveButton => WaitsHelper.WaitForExists(RemoveButtonBy);
        public IWebElement ShoppingCartBadge => WaitsHelper.WaitForExists(ShoppingCartBadgeBy);
        public IWebElement CheckoutButton => WaitsHelper.WaitForExists(CheckoutButtonBy);
        public bool ItemLabelInvisibility => WaitsHelper.WaitForElementInvisible(ItemLabelBy);
        public bool ShoppingCartBadgeInvisibility => WaitsHelper.WaitForElementInvisible(ShoppingCartBadgeBy);
    }
}
