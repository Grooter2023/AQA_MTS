using OpenQA.Selenium;
using Wrappers.Elements;
using Wrappers.Pages;

namespace Wrappers.Pages.ProjectPages.AldrethScalePage
{
    public class AldrethScalePage : BasePage
    {
        private static string END_POINT = "https://bymed.top/calc/aldret-2228";

        private static readonly By ShowAnnouncementRadioBy = By.Name("val_1");
        private static readonly By FrameBy = By.XPath("//*[@id='content']/div[2]/article/div/div[2]/div[1]/p[2]/iframe");
        private static readonly By GetSumBy = By.Id("sum");

        public AldrethScalePage(IWebDriver driver) : base(driver, true)
        {
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            throw new NotImplementedException();
        }

        public RadioButton ShowAnnouncementRadio => new RadioButton(Driver, ShowAnnouncementRadioBy);
        public Frame GetFrame => new Frame(Driver, FrameBy);
        public UIElement GetSum => new UIElement(Driver, GetSumBy);
    }
}
