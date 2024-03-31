using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using Patterns.Pages;
using Patterns.Pages.ProjectPages;

namespace Patterns.Steps
{
    public class DaysCalendarStep(IWebDriver driver) : BaseStep(driver)
    {
        public DaysCalendarPage CheckBox()
        {
            return StepsCheckBox<DaysCalendarPage>();
        }

        [AllureStep("Filling out the fields")]
        private T StepsCheckBox<T>() where T : BasePage
        {
            AllureLifecycle.Instance.UpdateStep(stepResult =>
            stepResult.parameters.Add(
            new Parameter
            {
                name = "Started at",
                value = DateTime.Now.ToString()
            }
            ));

            CalcPage = new CalcPage(Driver);
            DaysCalendarPage = new DaysCalendarPage(Driver);

            CalcPage.Сalculator.Click();

            IWebElement frame = DaysCalendarPage.GetFrame.GetId();
            Driver.SwitchTo().Frame(frame);

            DaysCalendarPage.ShowAnnouncementCheckbox.SetState(true);

            return (T)Activator.CreateInstance(typeof(T), Driver, false);
        }
    }
}
