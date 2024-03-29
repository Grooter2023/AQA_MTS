using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using Wrappers.Pages.ProjectPages;

namespace Wrappers.Steps
{
    public class SCFStep : BaseStep
    {
        private SCFPage sCFPage;

        public SCFStep(IWebDriver driver) : base(driver)
        {
            sCFPage = new SCFPage(driver);
        }

        [AllureStep("Filling out the fields")]
        public SCFPage SendKeys(string age, string сreatinine, string bodymass, string height)
        {
            AllureLifecycle.Instance.UpdateStep(stepResult =>
            stepResult.parameters.Add(
            new Parameter
            {
                name = "Started at",
                value = DateTime.Now.ToString()
            }
            ));

            sCFPage.AgeInput.SendKeys(age);
            sCFPage.СreatinineInput.SendKeys(сreatinine);
            sCFPage.BodymassInput.SendKeys(bodymass);
            sCFPage.HeightInput.SendKeys(height);
            sCFPage.SelectDropdown.SelectIndex(2);
            sCFPage.SexDropdown.SelectIndex(1);
            sCFPage.RaceDropdown.SelectIndex(1);
            sCFPage.СalcButton.Click();

            return sCFPage;
        }

        public SCFPage GetPage() => sCFPage;
    }

}
