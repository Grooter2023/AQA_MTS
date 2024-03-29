using OpenQA.Selenium;
using Wrappers.Pages.ProjectPages;
using Wrappers.Pages.ProjectPages.AldrethScalePage;

namespace Wrappers.Steps
{
    public class BaseStep
    {
        protected IWebDriver Driver;

        public BaseStep(IWebDriver driver)
        {
            Driver = driver;
        }
        public DaysCalendarPage DaysCalendarPage => new(Driver);
        public AldrethScalePage AldrethScalePage => new(Driver);
    }
}