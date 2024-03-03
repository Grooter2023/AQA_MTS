using OpenQA.Selenium;

namespace PageObjectSteps.Pages.ProjectPages;

public class AddProjectPage : ProjectBasePage
{
    private static string END_POINT = "index.php?/admin/projects/add";

    // �������� ���������
    private static readonly By AddButtonBy = By.Id("name");

    public AddProjectPage(IWebDriver driver) : base(driver)
    {
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        throw new NotImplementedException();
    }

    // ��������� ������
    public IWebElement AddButton => Driver.FindElement(AddButtonBy);
}