using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using Wrappers.Pages.ProjectPages;

namespace Wrappers.Tests;
[AllureEpic("Bdd.Feature_V1")]
[AllureFeature("Days-calendar.Checkbox")]
public class DaysCalendarTest : BaseTest
{
    [Test, Order(1)]
    [Description("Checking whether the check box is complete")]
    [AllureStory("Story_01")]
    [AllureSeverity((Allure.Net.Commons.SeverityLevel)SeverityLevel.critical)]
    [AllureOwner("Anisimova Tany")]
    [AllureLink("Website", "https://bymed.top/calc/days-calendar-2473")]
    [AllureTms("TMS-001")]
    public void CheckBox()
    {
        DaysCalendarPage daysCalendarPage = new DaysCalendarPage(Driver);

        IWebElement frame = daysCalendarPage.GetFrame.GetId();
        Driver.SwitchTo().Frame(frame);

        daysCalendarPage.ShowAnnouncementCheckbox.SetState(true); 

        Assert.Multiple(() => {
            Assert.That(daysCalendarPage.ShowAnnouncementCheckbox.IsChecked);

            Assert.That(daysCalendarPage.GetElemenytDayDiff.Text,
            Is.EqualTo("2 дня"));
        });
    }
}