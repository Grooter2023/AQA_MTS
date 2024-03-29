using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using Wrappers.Pages.ProjectPages.AldrethScalePage;

namespace Wrappers.Tests;
[AllureEpic("Bdd.Feature_V1")]
[AllureFeature("AldrethScale.Radio button")]

public class AldrethScaleTest : BaseTest
{
    [Test, Order(1)]
    [Description("Checking whether the check radio button is complete")]
    [AllureStory("Story_01")]
    [AllureSeverity((Allure.Net.Commons.SeverityLevel)SeverityLevel.critical)]
    [AllureOwner("Anisimova Tany")]
    [AllureLink("Website", "https://bymed.top/calc/aldret-2228")]
    [AllureTms("TMS-001")]
    public void RadioButton()
    {
        AldrethScalePage aldrethScalePage = new AldrethScalePage(Driver);

        IWebElement frame = aldrethScalePage.GetFrame.GetId();
        Driver.SwitchTo().Frame(frame);

        aldrethScalePage.ShowAnnouncementRadio.SelectByIndex(1);

        Assert.Multiple(() => {

            Assert.That(aldrethScalePage.GetSum.Text.Replace("\r\n", ""),
            Is.EqualTo("Всего баллов: 1Необходимость в наблюдении пациента после анестезиологического пособия:Менее 9 баллов - необходимо наблюдение врача-анестезиолога9 и более баллов - пациент готов к переводу в профильное отделение"));
        });
    }
}