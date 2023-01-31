using OnlinerTests;
using OpenQA.Selenium;

namespace DevByTests
{
    public class HomePage : BasePage
    {
        IWebElement _loginButtonOnHomeScreen = null;
        public HomePage(IWebDriver driver, ILogger logger) : base(driver, logger)
        {
            _loginButtonOnHomeScreen = FindElementByXPath(XPaths.LOGIN_BUTTON_HOME_SCREEN_XPATH);
        }
        public LoginPage GoToLogin()
        {
            _loginButtonOnHomeScreen?.Click();
            return new LoginPage(_driver, _logger);
        }
    }
}
