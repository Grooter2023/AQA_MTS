using OpenQA.Selenium;

namespace Wrappers.Elements
{
    public class Frame
    {
        private UIElement _uiElement;
        public Frame(IWebDriver webDriver, By by) => _uiElement = new UIElement(webDriver, by);
        public Frame(IWebDriver webDriver, IWebElement webElement) => _uiElement = new UIElement(webDriver, webElement);

        public IWebElement GetId() => _uiElement.GetWebElement;
    }
}
