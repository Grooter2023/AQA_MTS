using Allure.Net.Commons;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Wrappers.Elements;

namespace Wrappers.Pages.ProjectPages;

public class SCFPage : BasePage
{
    private static string END_POINT = "ñêô-2148";

    private static readonly By AgeInputBy = By.Id("age");
    private static readonly By ÑreatinineInputBy = By.Id("cr");
    private static readonly By BodymassInputBy = By.Id("mass");
    private static readonly By HeightInputBy = By.Id("grow");
    private static readonly By SelectDropdownBy = By.Id("cr-size");
    private static readonly By SexDropdownBy = By.Id("sex");
    private static readonly By RaceDropdownBy = By.Id("race");
    private static readonly By ÑalcButtonBy = By.XPath("//button[.='Ðàññ÷èòàòü']");
    private static readonly By FrameBy = By.XPath("//iframe[@src]");

    private static readonly By ResultTextMDRDBy = By.Id("mdrd_res");
    private static readonly By ResultTextCKDBy = By.Id("ckd_epi_res");
    private static readonly By ResultTextFormulaBy = By.Id("cge_res");

    public SCFPage(IWebDriver driver) : base(driver, true)
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

    public UIElement AgeInput => new UIElement(Driver, AgeInputBy);
    public UIElement ÑreatinineInput => new UIElement(Driver, ÑreatinineInputBy);
    public UIElement BodymassInput => new UIElement(Driver, BodymassInputBy);
    public UIElement HeightInput => new UIElement(Driver, HeightInputBy);
    public DropDownMenu SelectDropdown => new DropDownMenu(Driver, SelectDropdownBy);
    public DropDownMenu SexDropdown => new DropDownMenu(Driver, SexDropdownBy);
    public DropDownMenu RaceDropdown => new DropDownMenu(Driver, RaceDropdownBy);
    public UIElement ResultTextMDRD => new UIElement(Driver, ResultTextMDRDBy);
    public UIElement ResultTextCKD => new UIElement(Driver, ResultTextCKDBy);
    public UIElement ResultTextFormula => new UIElement(Driver, ResultTextFormulaBy);
    public Button ÑalcButton => new Button(Driver, ÑalcButtonBy);
    public Frame GetFrame => new Frame(Driver, FrameBy);
}