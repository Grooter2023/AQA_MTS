using OpenQA.Selenium;
using Patterns.Elements;
using Patterns.Pages;
using System.Reflection.Metadata;

namespace Patterns.Pages.ProjectPages
{
    public class AldrethScalePage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)

    {
        private const string END_POINT = "aldret-2228";

        private static readonly By ShowAnnouncementRadioBy = By.Name("val_1");
        private static readonly By FrameBy = By.XPath("//iframe[@src]");
        private static readonly By GetSumBy = By.Id("sum");

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        protected override bool EvaluateLoadedStatus()
        {
            throw new NotImplementedException();
        }

        public RadioButton ShowAnnouncementRadio => new RadioButton(Driver, ShowAnnouncementRadioBy);
        public Frame GetFrame => new Frame(Driver, FrameBy);
        public UIElement GetSum => new UIElement(Driver, GetSumBy);
    }
}
