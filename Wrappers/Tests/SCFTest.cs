using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using Patterns.Pages.ProjectPages;
using Patterns.Models;
using Patterns.Steps;

namespace Patterns.Tests;
[AllureEpic("Bdd.Feature_V1")]
[AllureFeature("SKF.Drop-down menu")]
public class SCFTest : BaseTest
{
    [Test, Order(1)]
    [Description("Checking whether the drop down menu is complete")]
    [AllureStory("Story_01")]
    [AllureSeverity(SeverityLevel.critical)]
    [AllureOwner("Anisimova Tany")]
    [AllureLink("Website", "https://bymed.top/calc/скф-2148")]
    [AllureTms("TMS-001")]
    public void DropDownMenu()
    {
        SCFPage sCFPage = new SCFPage(Driver);

        Assert.Multiple(() =>
        {
            _sCFStep.DropDownMenu(new SCF()
            {
                Age = "32",
                Creatinine = "123",
                Bodymass = "80",
                Height = "183"
            });

            Assert.That(sCFPage.ResultTextMDRD.Text, Is.EqualTo("0.3"));
            Assert.That(sCFPage.ResultTextCKD.Text, Is.EqualTo("0.26"));
            Assert.That(sCFPage.ResultTextFormula.Text, Is.EqualTo("0.83"));
        });
    }
}