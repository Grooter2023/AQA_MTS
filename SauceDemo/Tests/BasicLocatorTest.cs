using OpenQA.Selenium;
using SauceDemo.Helpers;
using System.Security.Permissions;
using System.Xml.Linq;

namespace SauceDemo.Tests
{
    [TestFixture, Category("Smoke")]
    public class BasicLocatorTest : BaseTest
    {
        [Test, Order(1)]
        [Description("Search by ID")]
        [Severity(SeverityLevel.Trivial)]
        public void SearchById()
        {                
            IWebElement resultSearchById = Driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)"));
            Assert.That(resultSearchById.Text, Is.EqualTo("Add to cart"));
        }
       
        [Test, Order(2)]
        [Description("Search by name")]
        [Severity(SeverityLevel.Trivial)]
        public void SearchByName()
        {
            IWebElement resultSearchByName = Driver.FindElement(By.Name("add-to-cart-sauce-labs-onesie"));
            Assert.That(resultSearchByName.Text, Is.EqualTo("Add to cart"));
        }
       
        [Test, Order(3)]
        [Description("Search by classname")]
        [Severity(SeverityLevel.Trivial)]
        public void SearchByСlassname()
        { 
            IWebElement resultSearchByСlassname = Driver.FindElement(By.ClassName("social_facebook"));
            Assert.That(resultSearchByСlassname.Text, Is.EqualTo("Facebook"));
        }

        [Test, Order(4)]
        [Description("Search by tagname")]
        [Severity(SeverityLevel.Trivial)]
        public void SearchByTagname()
        {
            Assert.That(Driver.FindElement(By.TagName("footer")).Displayed);
        }
        
        [Test, Order(5)]
        [Description("Search by linktext")]
        [Severity(SeverityLevel.Trivial)]
        public void SearchByLinktext()
        {
            IWebElement resultSearchByLinktext = Driver.FindElement(By.LinkText("Sauce Labs Backpack"));
            Assert.That(resultSearchByLinktext.Text, Is.EqualTo("Sauce Labs Backpack"));
        }

        [Test, Order(6)]
        [Description("Search by partiallinktext")]
        [Severity(SeverityLevel.Trivial)]
        public void SearchByPartialLinkText()
        {
            IWebElement resultSearchByPartialLinkText = Driver.FindElement(By.LinkText("LinkedIn"));
            Assert.That(resultSearchByPartialLinkText.Text, Is.EqualTo("LinkedIn"));
        }
    }
}
