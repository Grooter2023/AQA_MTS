using OpenQA.Selenium;
using SeleniumBasic.Helpers;

namespace SeleniumBasic.Pages.ProjectPages;

public abstract class ProjectBasePage : BasePage
{
    private static readonly By NameInputBy = By.Id("name");

    public ProjectBasePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

   /* protected ProjectBasePage(IWebDriver driver)
    {
    }*/

    // Атомарные Методы
    public IWebElement NameInput => WaitsHelper.WaitForExists(NameInputBy);
}