using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using Patterns.Pages;
using Patterns.Pages.ProjectPages;

namespace Patterns.Steps
{
    public class AldrethScaleStep(IWebDriver driver) : BaseStep(driver)
    {
        public AldrethScalePage RadioButton()
        {
            return StepsRadioButton<AldrethScalePage>();
        }

        [AllureStep("Filling out the fields")]
        private T StepsRadioButton<T>() where T : BasePage
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
            AldrethScalePage = new AldrethScalePage(Driver);

            CalcPage.Aldret.Click();

            IWebElement frame = AldrethScalePage.GetFrame.GetId();
            Driver.SwitchTo().Frame(frame);

            AldrethScalePage.ShowAnnouncementRadio.SelectByIndex(1);

            return (T)Activator.CreateInstance(typeof(T), Driver, false);
        }
    }
}
