using SauceDemo_PageObject_Steps.Helpers;
using SauceDemo_PageObject_Steps.Steps;
using SauceDemo_PageObject_Steps.Helpers.Configuration;

namespace SauceDemo_PageObject_Steps.Tests
{
    [TestFixture, Category("Unit")]
    public class ProductTests : BaseTest
    {
        [Test, Order(1)]
        [Description("Adding product to cart")]
        [Severity(SeverityLevel.Minor)]
        public void AddingProductToCart()
        {
            NavigationSteps.Authorization(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            Assert.That(NavigationSteps.InventoryPage.IsPageOpened());

            ProductSteps.AddingProductCart();

            Assert.Multiple(() =>
            {
                Assert.That(ProductSteps.InventoryPage.RemoveBackpackButton.Text, Is.EqualTo("Remove"));
                Assert.That(ProductSteps.InventoryPage.ShoppingCartBadge.Text, Is.EqualTo("1"));
            });
        }
    }
}
