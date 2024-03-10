using SauceDemo_PageObject_Steps.Steps;
using SauceDemo_PageObject_Steps.Helpers.Configuration;
using Allure.Net.Commons;

namespace SauceDemo_PageObject_Steps.Tests
{
    [TestFixture]
    public class ProductTests : BaseTest
    {
        [Test]
        public void AddingProductToCart()
        {
            AllureApi.SetDescription("Adding product to cart");
            AllureApi.AddFeature("AllureApi");
            AllureApi.AddFeature("Essential feature");
            AllureApi.AddFeature("Integration feature");
            AllureApi.AddStory("Story3");
            AllureApi.SetOwner("Anisimova Tany");

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
