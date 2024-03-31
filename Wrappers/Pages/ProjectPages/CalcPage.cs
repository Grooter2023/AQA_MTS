using OpenQA.Selenium;
using Patterns.Elements;
using Patterns.Pages;

namespace Patterns.Pages.ProjectPages
{
    public class CalcPage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
    {
        private const string END_POINT = "";

        private static readonly By NextPageNumbersBy = By.XPath("//*[@id='content']/div[2]/nav/ul/li[1]/a[2]");
        private static readonly By AldretBy = By.XPath("//*[@id='post-2228']/div/div[2]/h2/a");
        private static readonly By СalculatorBy = By.XPath("//*[@id='post-2473']/div/div[2]/h2/a");

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        protected override bool EvaluateLoadedStatus()
        {
            throw new NotImplementedException();
        }

        public UIElement NextPageNumbers => new UIElement(Driver, NextPageNumbersBy);
        public UIElement Aldret => new UIElement(Driver, AldretBy);
        public UIElement Сalculator => new UIElement(Driver, СalculatorBy);
    }
}
