using OpenQA.Selenium;

namespace SauceDemo_PageObject_Steps.Pages
{
    public class InventoryPage : BasePage
    {
        private static string END_POINT = "/inventory.html";

        private static readonly By TitleBy = By.XPath("//*[@class='title' and text()='Products']");
        private static readonly By InventoryItemNameBy = By.XPath("//*[@class='inventory_item_name ' and text()='Sauce Labs Backpack']");
        private static readonly By AddBackpackButtonBy = By.Id("add-to-cart-sauce-labs-backpack");
        private static readonly By RemoveBackpackButtonBy = By.Id("remove-sauce-labs-backpack");
        private static readonly By ShoppingCartBadgeBy = By.XPath("//span[@class='shopping_cart_badge']");

        public InventoryPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
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
                return Title.Text.Trim().Equals("Products");
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void ClickAddToCartBackBackButton() => AddBackpackButton.Click();

        public IWebElement Title => WaitsHelper.WaitForExists(TitleBy);
        public IWebElement InventoryItemName => WaitsHelper.WaitForExists(InventoryItemNameBy);
        public IWebElement AddBackpackButton => WaitsHelper.WaitForExists(AddBackpackButtonBy);
        public IWebElement RemoveBackpackButton => WaitsHelper.WaitForExists(RemoveBackpackButtonBy);
        public IWebElement ShoppingCartBadge => WaitsHelper.WaitForExists(ShoppingCartBadgeBy);
    }
}
