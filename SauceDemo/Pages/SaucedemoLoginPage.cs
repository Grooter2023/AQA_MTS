using OpenQA.Selenium;

namespace SauceDemo_PageObject_Steps.Pages
{
    public class SaucedemoLoginPage : BasePage
    {
        private static string END_POINT = "";

        private static readonly By InputUserNameBy = By.Id("user-name");
        private static readonly By InputPasswordBy = By.Id("password");
        private static readonly By PressButtonLoginBy = By.Id("login-button");
        private static readonly By ErrorTextBy = By.ClassName("error-message-container");

        public SaucedemoLoginPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            try
            {
                return PressButtonLogin.Displayed && InputUserName.Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string ErrorText => WaitsHelper.WaitForExists(ErrorTextBy).Text;

        public IWebElement InputUserName => WaitsHelper.WaitForExists(InputUserNameBy);
        public IWebElement InputPassword => WaitsHelper.WaitForExists(InputPasswordBy);
        public IWebElement PressButtonLogin => WaitsHelper.WaitForExists(PressButtonLoginBy);
    }
}
