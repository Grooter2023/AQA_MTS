using SauceDemo_PageObject_Steps.Helpers;
using SauceDemo_PageObject_Steps.Helpers.Configuration;

namespace SauceDemo_PageObject_Steps.Tests
{
    [TestFixture, Category("Smoke")]
    public class SaucedemoLoginTests : BaseTest
    {
        [Test, Order(1)]
        [Description("Checking for login standard user")]
        [Severity(SeverityLevel.Critical)]
        public void CheckForLoginStandardUser()
        {
            var username = Configurator.AppSettings.Username;
            var password = Configurator.AppSettings.Password;

            NavigationSteps.Authorization(username, password);

            Assert.That(NavigationSteps.InventoryPage.IsPageOpened());
        }

        [Test, Order(2)]
        [Description("Checking a blocked login - \"locked_out_user\"")]
        [Severity(SeverityLevel.Critical)]
        public void CheckingABlockedLogin()
        {
            var errorText = "Epic sadface: Sorry, this user has been locked out.";
            var username = "locked_out_user";
            var password = Configurator.AppSettings.Password;

            Assert.That(
                NavigationSteps
                    .Authorization(username, password)
                    .ErrorText,
                Is.EqualTo(errorText)
                );
        }

        [Test, Order(3)]
        [Description("Checking without specifying a password")]
        [Severity(SeverityLevel.Critical)]
        public void CheckingForNonExistentUser()
        {
            var errorText = "Epic sadface: Password is required";
            var username = "problem_user";
            var password = "";

            Assert.That(
                NavigationSteps
                    .Authorization(username, password)
                    .ErrorText,
                Is.EqualTo(errorText)
                );
        }
    }
}