using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using Patterns.Pages.ProjectPages;
using Patterns.Pages;
using Patterns.Models;

namespace Patterns.Steps
{
    public class SCFStep(IWebDriver driver) : BaseStep(driver)
    {
        public SCFPage DropDownMenu(SCF sCF)
        {
            return SendKeys<SCFPage>(sCF);
        }

        [AllureStep("Navigating through pages and filling out fields")]
        private T SendKeys<T>(SCF sCF) where T : BasePage
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
            Page_2Page = new Page_2Page(Driver);
            SCFPage = new SCFPage(Driver);

            CalcPage.NextPageNumbers.Click();
            Page_2Page.SKF.Click();

            IWebElement frame = SCFPage.GetFrame.GetId();
            Driver.SwitchTo().Frame(frame);

            SCFPage.AgeInput.SendKeys(sCF.Age);
            SCFPage.СreatinineInput.SendKeys(sCF.Creatinine);
            SCFPage.BodymassInput.SendKeys(sCF.Bodymass);
            SCFPage.HeightInput.SendKeys(sCF.Height);
            SCFPage.SelectDropdown.SelectIndex(2);
            SCFPage.SexDropdown.SelectIndex(1);
            SCFPage.RaceDropdown.SelectIndex(1);
            SCFPage.СalcButton.Click();

            return (T)Activator.CreateInstance(typeof(T), Driver, false);
        }
    }
}
