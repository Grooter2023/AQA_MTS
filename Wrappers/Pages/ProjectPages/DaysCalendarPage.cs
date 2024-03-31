using OpenQA.Selenium;
using Patterns.Elements;
using Patterns.Pages;

namespace Patterns.Pages.ProjectPages;

public class DaysCalendarPage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
{
    private const string END_POINT = "days-calendar-2473";

    private static readonly By ShowAnnouncementCheckboxBy = By.Id("last-day");
    private static readonly By FrameBy = By.XPath("//iframe[@src]");
    private static readonly By DayDiffBy = By.Id("day-diff");

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    protected override bool EvaluateLoadedStatus()
    {
        throw new NotImplementedException();
    }


    public Checkbox ShowAnnouncementCheckbox => new Checkbox(Driver, ShowAnnouncementCheckboxBy);
    public Frame GetFrame => new Frame(Driver, FrameBy);
    public UIElement GetElemenytDayDiff => new UIElement(Driver, DayDiffBy);
}