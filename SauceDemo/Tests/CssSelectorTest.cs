using OpenQA.Selenium;
using SauceDemo.Helpers;

namespace SauceDemo.Tests
{
    [TestFixture, Category("Regression")]
    public class CssSelectorTest : BaseTest
    {
        [Test, Order(1)]
        [Description("Search by class")]
        [Severity(SeverityLevel.Minor)]
        public void SearchByСlass()
        {
            IWebElement resultSearchByСlass = Driver.FindElement(By.CssSelector(".app_logo"));
            Assert.That(resultSearchByСlass.Text, Is.EqualTo("Swag Labs"));
        }

        [Test, Order(2)]
        [Description("Search by .class1.class2")]
        [Severity(SeverityLevel.Minor)]
        public void Search0ByClass1Class2()
        {
            IWebElement resultSearch0ByClass1Class2 = Driver.FindElement(By.CssSelector(".btn.btn_primary"));
            Assert.That(resultSearch0ByClass1Class2.Text, Is.EqualTo("Add to cart"));
        }

        [Test, Order(3)]
        [Description("Search by .class1 .class2")]
        [Severity(SeverityLevel.Minor)]
        public void Search1ByClass1Class2()
        {
            Assert.That(Driver.FindElement(By.CssSelector(".page_wrapper .bm-burger-button")).Displayed);
        }

        [Test, Order(4)]
        [Description("Search by #id")]
        [Severity(SeverityLevel.Minor)]
        public void SearchByIdCSS()
        {
            IWebElement resultSearchByIdCSS = Driver.FindElement(By.CssSelector("#react-burger-menu-btn"));
            Assert.That(resultSearchByIdCSS.Text, Is.EqualTo("Open Menu"));
        }

        [Test, Order(5)]
        [Description("Search by tagname")]
        [Severity(SeverityLevel.Minor)]
        public void SearchByTagName()
        {
            Assert.That(Driver.FindElement(By.CssSelector("footer")).Displayed);
        }

        [Test, Order(6)]
        [Description("Search by tagname.class")]
        [Severity(SeverityLevel.Minor)]
        public void SearchByTagNameClass()
        {
            Assert.That(Driver.FindElement(By.CssSelector("footer.footer")).Displayed);
        }


        [Test, Order(7)]
        [Description("Search with [attribute=value]")]
        [Severity(SeverityLevel.Minor)]
        public void SearchWithAttributeValue0()
        {
            Assert.That(Driver.FindElement(By.CssSelector("[class=footer_copy]")).Displayed);
        }

        [Test, Order(8)]
        [Description("Search with [attribute~=value]")]
        [Severity(SeverityLevel.Minor)]
        public void SearchWithAttrInacVal()
        {
            Assert.That(Driver.FindElement(By.CssSelector("[class~=social]")).Displayed);
        }

        [Test, Order(9)]
        [Description("Search with [attribute|=value]")]
        [Severity(SeverityLevel.Minor)]
        public void SearchWithAttrVal1()
        {
            Assert.That(Driver.FindElements(By.CssSelector("[class|=bm]")).Count, Is.EqualTo(11));
        }
        
        [Test, Order(10)]
        [Description("Search with [attribute^=value]")]
        [Severity(SeverityLevel.Minor)]
        public void SearchWithAttrVal2()
        {
            Assert.That(Driver.FindElements(By.CssSelector("a[href^='https://']")).Count, Is.EqualTo(4));
        }
       
        [Test, Order(11)]
        [Description("Search with [attribute$=value]")]
        [Severity(SeverityLevel.Trivial)]
        public void SearchWithAttrVal3()
        {
            Assert.That(Driver.FindElements(By.CssSelector("[id$='btn']")).Count, Is.EqualTo(2));
        }

        [Test, Order(12)]
        [Description("Search with [attribute*=value]")]
        [Severity(SeverityLevel.Trivial)]
        public void SearchWithAttrVal4()
        {
            Assert.That(Driver.FindElements(By.CssSelector("[id$='btn']")).Count, Is.EqualTo(2));
        }

    }
}
