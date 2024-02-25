using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SauceDemo.Helpers;

namespace SauceDemo.Tests
{
    [TestFixture, Category("Smoke")]
    public class SeleniumWebDriverTest : BaseTest
    {
        [Test, Order(1)]
        [Description("Context Menu Page Test")]
        [Severity(SeverityLevel.Critical)]
        public void СontextMenuPageTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/context_menu");

            var actions = new Actions(Driver);

            actions.MoveToElement(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("hot-spot")), 25, 25);
            actions.ContextClick();
            actions.Build();
            actions.Perform();

            IAlert alert = Driver.SwitchTo().Alert();

            Assert.That(alert.Text, Is.EqualTo("You selected a context menu"));
            alert.Accept();
        }

        [Test, Order(2)]
        [Description("Dynamic Controls Page Test")]
        [Severity(SeverityLevel.Critical)]
        public void DynamicControlsPageTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dynamic_controls");

            var buttonRemove = WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("button[onclick = 'swapCheckbox()']"));
            var buttonEnable = WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("button[onclick = 'swapInput()']"));
            var checkBox = WaitsHelper.WaitForVisibilityLocatedBy(By.Id("checkbox")); 
            var inputText = WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("input[type='text']"));


            buttonRemove.Click();

            Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("message")).Text, Is.EqualTo("It's gone!"));
            Assert.That(WaitsHelper.WaitForElementInvisible(checkBox));
            Assert.That(!inputText.Enabled);

            buttonEnable.Click();
 
            Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("message")).Text, Is.EqualTo("It's enabled!"));
            Assert.That(inputText.Enabled);
        }

        [Test, Order(4)]
        [Description("Frames Page Test")]
        [Severity(SeverityLevel.Critical)]
        public void FramesPageTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/frames");

            WaitsHelper.WaitForVisibilityLocatedBy(By.LinkText("iFrame")).Click();

            Driver.SwitchTo().Frame(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("mce_0_ifr")));

            Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("tinymce")).Text, Is.EqualTo("Your content goes here."));
        }
    }
}
