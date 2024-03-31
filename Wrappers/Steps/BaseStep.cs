using OpenQA.Selenium;
using Patterns.Pages.ProjectPages;

namespace Patterns.Steps
{
    public class BaseStep(IWebDriver driver)
    {
        protected readonly IWebDriver Driver = driver;

        protected AldrethScalePage? AldrethScalePage { get; set; }
        protected DaysCalendarPage? DaysCalendarPage { get; set; }
        protected SCFPage? SCFPage { get; set; }
        protected CalcPage? CalcPage { get; set; }
        protected Page_2Page? Page_2Page { get; set; }
    }
}