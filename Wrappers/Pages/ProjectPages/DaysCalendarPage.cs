using OpenQA.Selenium;
using Wrappers.Elements;

namespace Wrappers.Pages.ProjectPages;

public class DaysCalendarPage : BasePage
{
    private static string END_POINT = "days-calendar-2473";

    private static readonly By ShowAnnouncementCheckboxBy = By.Id("last-day");
    private static readonly By FrameBy = By.XPath("//*[@id='content']/div[2]/article/div/div[2]/div[1]/p/iframe");
    private static readonly By DayDiffBy = By.Id("day-diff");

    public DaysCalendarPage(IWebDriver driver) : base(driver, true)
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

    public Checkbox ShowAnnouncementCheckbox => new Checkbox(Driver, ShowAnnouncementCheckboxBy);
    public Frame GetFrame => new Frame(Driver, FrameBy);
    public UIElement GetElemenytDayDiff => new UIElement(Driver, DayDiffBy);
}