using OpenQA.Selenium;
using SauceDemo.Helpers;

namespace SauceDemo.Tests
{
    [TestFixture, Category("Regression")]
    public class XPathSelectorTest : BaseTest
    {
        [Test, Order(1)]
        [Description("Search by attribute")]
        [Severity(SeverityLevel.Major)]
        public void SearchByAttribute()
        {
            IWebElement resultSearchByAttribute = Driver.FindElement(By.XPath("//div[@class='app_logo']"));
            Assert.That(resultSearchByAttribute.Text, Is.EqualTo("Swag Labs"));
        }

        [Test, Order(2)]
        [Description("Search by text")]
        [Severity(SeverityLevel.Major)]
        public void SearchByText()
        {
            Assert.That(Driver.FindElement(By.XPath("//div[text()='Swag Labs']")).Displayed);
        }

        [Test, Order(3)]
        [Description("Search by partial attribute match")]
        [Severity(SeverityLevel.Major)]
        public void SearchByPartialAttributeMatch()
        {
            IWebElement resultSearchByPartialAttributeMatch = Driver.FindElement(By.XPath("//button[contains(@class,'btn_inventory')]"));
            Assert.That(resultSearchByPartialAttributeMatch.Text, Is.EqualTo("Add to cart"));
        }

        [Test, Order(4)]
        [Description("Search by partial text match")]
        [Severity(SeverityLevel.Major)]
        public void SearchByPartialTextMatch()
        {
            IWebElement resultSearchByPartialTextMatch = Driver.FindElement(By.XPath("//button[contains(text(),'Add to')]"));
            Assert.That(resultSearchByPartialTextMatch.Text, Is.EqualTo("Add to cart"));
        }

        [Test, Order(5)]
        [Description("Search with ancestor")]
        [Severity(SeverityLevel.Major)]
        public void SearchWithAncestor()
        {
            IWebElement resultSearchWithAncestor = Driver.FindElement(By.XPath("//li/ancestor::ul[@class = 'social']"));
            Assert.That(resultSearchWithAncestor.Text.Replace("\r\n", ""), Is.EqualTo("TwitterFacebookLinkedIn"));
        }

        [Test, Order(6)]
        [Description("Search with descendant")]
        [Severity(SeverityLevel.Major)]
        public void SearchWithDescendant()
        {
            IWebElement resultSearchWithDescendant = Driver.FindElement(By.XPath("//footer[@class='footer']//descendant::li[@class='social_facebook']"));
            Assert.That(resultSearchWithDescendant.Text, Is.EqualTo("Facebook"));
        }
 
        [Test, Order(7)]
        [Description("Search with following")]
        [Severity(SeverityLevel.Major)]
        public void SearchWithFollowing()
         {
            Assert.That(Driver.FindElement(By.XPath("//div[@class='inventory_item']//following::a[@id='item_0_img_link']")).Displayed);
         }

        [Test, Order(8)]
        [Description("Search with parent")]
        [Severity(SeverityLevel.Major)]
        public void SearchWithParent()
        {
            Assert.That(Driver.FindElement(By.XPath("//*[@class='social_twitter']//parent::ul")).Displayed); 
        }

        [Test, Order(9)]
        [Description("Search with preceding")]
        [Severity(SeverityLevel.Major)]
        public void SearchByWithPreceding()
        {
            Assert.That(Driver.FindElement(By.XPath("//*[@id='item_0_img_link']//preceding::span")).Displayed);
        }
    }
}
