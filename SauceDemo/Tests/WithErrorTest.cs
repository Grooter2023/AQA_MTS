using Allure.Net.Commons;
using NUnit.Allure.Attributes;

namespace SauceDemo_PageObject_Steps.Tests
{
    [TestFixture, Category("Smoke")]
    public class WithErrorTest : BaseTest
    {
        [Test, Order(1)]
        [Description("Test with error")]
        [AllureSeverity((Allure.Net.Commons.SeverityLevel)SeverityLevel.trivial)]
        [AllureOwner("Anisimova Tany")]
        [AllureLink("Website", "https://www.saucedemo.com")]
        [AllureStory("Test Story")]
        [AllureTms("TMS-001")]
        public void TestWithError()
        {
            var errorText = "";
            var username = "";
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
