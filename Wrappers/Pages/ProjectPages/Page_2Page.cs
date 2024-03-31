using OpenQA.Selenium;
using Patterns.Elements;
using Patterns.Pages;

namespace Patterns.Pages.ProjectPages
{
    public class Page_2Page(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
    {
        private const string END_POINT = "page/2";

        private static readonly By SKFBy = By.XPath("//*[@id='post-2148']/div/div[2]/h2/a");

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        protected override bool EvaluateLoadedStatus()
        {
            throw new NotImplementedException();
        }

        public UIElement SKF => new UIElement(Driver, SKFBy);
    }
}
