using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using Wrappers.Pages.ProjectPages;
using Wrappers.Steps;

namespace Wrappers.Tests;
[AllureEpic("Bdd.Feature_V1")]
[AllureFeature("SKF.Drop-down menu")]
public class SCFTest : BaseTest
{
    [Test, Order(1)]
    [Description("Checking whether the drop down menu is complete")]
    [AllureStory("Story_01")]
    [AllureSeverity((Allure.Net.Commons.SeverityLevel)SeverityLevel.critical)]
    [AllureOwner("Anisimova Tany")]
    [AllureLink("Website", "https://bymed.top/calc/скф-2148")]
    [AllureTms("TMS-001")]
    public void DropDownMenu()
    {
        string age = "32";
        string сreatinine = "123";
        string bodymass = "80";
        string height = "183";

        SCFStep sCFStep = new SCFStep(Driver);
        SCFPage sCFPage = sCFStep.GetPage();

        IWebElement frame = sCFPage.GetFrame.GetId();
        Driver.SwitchTo().Frame(frame);

        sCFStep.SendKeys(age, сreatinine, bodymass, height);
        
        Assert.Multiple(() => {

            Assert.That(sCFPage.ResultTextMDRD.Text,
            Is.EqualTo("0.3"));

            Assert.That(sCFPage.ResultTextCKD.Text,
            Is.EqualTo("0.26"));

            Assert.That(sCFPage.ResultTextFormula.Text,
            Is.EqualTo("0.83"));
        });
    }
}