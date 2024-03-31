using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using Patterns.Pages.ProjectPages;

namespace Patterns.Tests;
[AllureEpic("Bdd.Feature_V1")]
[AllureFeature("Days-calendar.Checkbox")]
public class DaysCalendarTest : BaseTest
{
    [Test, Order(1)]
    [Description("Checking whether the check box is complete")]
    [AllureStory("Story_01")]
    [AllureSeverity(SeverityLevel.critical)]
    [AllureOwner("Anisimova Tany")]
    [AllureLink("Website", "https://bymed.top/calc/days-calendar-2473")]
    [AllureTms("TMS-001")]
    public void CheckBox()
    {
        DaysCalendarPage daysCalendarPage = new DaysCalendarPage(Driver);
        _daysCalendarStep.CheckBox();

        Assert.Multiple(() =>
        {
            Assert.That(daysCalendarPage.ShowAnnouncementCheckbox.IsChecked);
            Assert.That(daysCalendarPage.GetElemenytDayDiff.Text, Is.EqualTo("2 дня"));
        });
    }
}