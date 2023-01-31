using OnlinerTests;
using OpenQA.Selenium;

namespace DevByTests
{
    public class LoginPage : BasePage
    {
        IWebElement _usernameField = null;
        IWebElement _passwordField = null;
        IWebElement _loginButton = null;
        public LoginPage(IWebDriver driver, ILogger logger): base(driver, logger)
        {
            _usernameField = FindElementByXPath(XPaths.USERNAME_FIELD_XPATH);
            _passwordField = FindElementByXPath(XPaths.PASSWORD_FIELD_XPATH);
            _loginButton = FindElementByXPath(XPaths.LOGIN_BUTTON_XPATH);

        }
        public void Login(string username, string password)
        {          
            _usernameField?.Click();
            _usernameField?.SendKeys(username);
            _passwordField?.Click();
            _passwordField?.SendKeys(password);
            _loginButton?.Click();         
        }
    }
}
