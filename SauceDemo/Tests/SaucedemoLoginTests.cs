using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using SauceDemo_PageObject_Steps.Helpers.Configuration;

namespace SauceDemo_PageObject_Steps.Tests
{
    [AllureEpic("Bdd")]
    [AllureEpic("Web Interface")]
    [AllureFeature("Essential feature", "Integration feature")]
    public class SaucedemoLoginTests : BaseTest
    {
        [Test, Order(1)]
        [Description("Checking for login standard user")]
        [AllureStory("Story1")]
        [AllureSeverity((Allure.Net.Commons.SeverityLevel)SeverityLevel.critical)]
        [AllureOwner("Anisimova Tany")]
        [AllureLink("Website", "https://www.saucedemo.com")]
        [AllureTms("TMS-001")]
        public void CheckForLoginStandardUser()
        {
            var username = Configurator.AppSettings.Username;
            var password = Configurator.AppSettings.Password;

            NavigationSteps.Authorization(username, password);

            Assert.That(NavigationSteps.InventoryPage.IsPageOpened());
        }

        [Test, Order(2)]
        [Description("Checking a blocked login - \"locked_out_user\"")]
        [AllureStory("Story2")]
        [AllureSeverity((Allure.Net.Commons.SeverityLevel)SeverityLevel.minor)]
        [AllureOwner("Anisimova Tany")]
        [AllureLink("Website", "https://www.saucedemo.com")]
        [AllureTms("TMS-001")]
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
        [AllureStory("Story3")]
        [AllureSeverity((Allure.Net.Commons.SeverityLevel)SeverityLevel.trivial)]
        [AllureOwner("Anisimova Tany")]
        [AllureLink("Website", "https://www.saucedemo.com")]
        [AllureTms("TMS-001")]
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