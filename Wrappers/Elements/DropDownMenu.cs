using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using UIElementsUnturned.UIElementsLib.Core.UI.Elements;
using static System.Net.Mime.MediaTypeNames;


namespace Wrappers.Elements;

public class DropDownMenu
{
    private UIElement dropDown;
    private List<UIElement> dropDownList;

    public DropDownMenu(IWebDriver driver, By by)
    {
        dropDown = new UIElement(driver, by);
        
        dropDown.Click();
        dropDownList = dropDown.FindUIElements(By.XPath("descendant::option"));
    }

    public void SelectText(string text)
    {
        try
        {
            foreach (var webElement in dropDownList)
            {
                if (webElement.Text == text)
                {  
                    webElement.Click();
                    break;
                }
            }
        }
        catch
        {
            throw new AssertionException("Не найден");
        }
    }

    public void SelectIndex(int index)
    {
        try
        {
            dropDownList[index].Click();
        }
        catch
        {
            throw new AssertionException("Не найден");
        }
    }
}